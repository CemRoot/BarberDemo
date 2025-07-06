// Berber Demo JavaScript
document.addEventListener('DOMContentLoaded', function() {
    // Form elements
    const appointmentForm = document.getElementById('appointmentForm');
    const dateInput = document.getElementById('appointmentDate');
    const timeSelect = document.getElementById('appointmentTime');
    
    // Calendly buttons
    const calendlyBtn = document.getElementById('calendlyBtn');
    const calendlyBtnMain = document.getElementById('calendlyBtnMain');
    const navCalendlyBtn = document.getElementById('navCalendlyBtn');
    
    // Modals
    const successModal = new bootstrap.Modal(document.getElementById('successModal'));
    const errorModal = new bootstrap.Modal(document.getElementById('errorModal'));
    
    // Set minimum date to today
    const today = new Date().toISOString().split('T')[0];
    dateInput.setAttribute('min', today);
    
    // Calendly popup event handlers
    if (calendlyBtn) {
        calendlyBtn.addEventListener('click', function(e) {
            e.preventDefault();
            openCalendlyPopup();
        });
    }
    
    if (calendlyBtnMain) {
        calendlyBtnMain.addEventListener('click', function(e) {
            e.preventDefault();
            openCalendlyPopup();
        });
    }
    
    if (navCalendlyBtn) {
        navCalendlyBtn.addEventListener('click', function(e) {
            e.preventDefault();
            openCalendlyPopup();
        });
    }
    
    // Function to open Calendly popup
    function openCalendlyPopup() {
        if (window.Calendly) {
            window.Calendly.initPopupWidget({
                url: 'https://calendly.com/isgelistirme41/30min',
                text: 'Randevu Al',
                color: '#e74c3c',
                textColor: '#ffffff',
                branding: true
            });
        } else {
            // Fallback: open in new tab if Calendly script not loaded
            window.open('https://calendly.com/isgelistirme41/30min', '_blank');
        }
    }
    
    // Smooth scrolling for navigation links
    document.querySelectorAll('a[href^="#"]').forEach(anchor => {
        anchor.addEventListener('click', function (e) {
            e.preventDefault();
            const target = document.querySelector(this.getAttribute('href'));
            if (target) {
                target.scrollIntoView({
                    behavior: 'smooth',
                    block: 'start'
                });
            }
        });
    });
    
    // Form validation and submission
    appointmentForm.addEventListener('submit', async function(e) {
        e.preventDefault();
        
        // Get form data
        const formData = {
            customer: document.getElementById('customerName').value.trim(),
            email: document.getElementById('customerEmail').value.trim(),
            date: combineDateTime(dateInput.value, timeSelect.value),
            service: document.getElementById('serviceType').value
        };
        
        // Validate form
        if (!validateForm(formData)) {
            return;
        }
        
        // Show loading state
        const submitButton = appointmentForm.querySelector('button[type="submit"]');
        const originalText = submitButton.innerHTML;
        submitButton.innerHTML = '<i class="fas fa-spinner fa-spin"></i> Kaydediliyor...';
        submitButton.disabled = true;
        
        try {
            // Send appointment request
            const response = await fetch('/api/appointments', {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json',
                },
                body: JSON.stringify({
                    customer: formData.customer,
                    email: formData.email,
                    date: formData.date
                })
            });
            
            if (response.ok) {
                // Success
                successModal.show();
                appointmentForm.reset();
                clearValidationStates();
            } else {
                // Error
                const errorData = await response.text();
                showError(errorData || 'Randevu kaydedilirken bir hata oluştu.');
            }
        } catch (error) {
            console.error('Error:', error);
            showError('Bağlantı hatası. Lütfen internet bağlantınızı kontrol edin.');
        } finally {
            // Reset button
            submitButton.innerHTML = originalText;
            submitButton.disabled = false;
        }
    });
    
    // Real-time form validation
    const inputs = appointmentForm.querySelectorAll('input, select');
    inputs.forEach(input => {
        input.addEventListener('blur', function() {
            validateField(this);
        });
        
        input.addEventListener('input', function() {
            // Clear invalid state on input
            if (this.classList.contains('is-invalid')) {
                this.classList.remove('is-invalid');
            }
        });
    });
    
    // Date change handler - update available times
    dateInput.addEventListener('change', function() {
        updateAvailableTimes(this.value);
    });
    
    function combineDateTime(date, time) {
        if (!date || !time) return null;
        
        const dateObj = new Date(date);
        const [hours, minutes] = time.split(':');
        
        dateObj.setHours(parseInt(hours), parseInt(minutes), 0, 0);
        
        // Convert to UTC for API
        return dateObj.toISOString();
    }
    
    function validateForm(data) {
        let isValid = true;
        
        // Validate name
        if (!data.customer || data.customer.length < 2) {
            setFieldError('customerName', 'Ad soyad en az 2 karakter olmalıdır.');
            isValid = false;
        }
        
        // Validate email
        const emailPattern = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
        if (!data.email || !emailPattern.test(data.email)) {
            setFieldError('customerEmail', 'Geçerli bir e-posta adresi girin.');
            isValid = false;
        }
        
        // Validate date
        if (!data.date) {
            setFieldError('appointmentDate', 'Tarih seçin.');
            setFieldError('appointmentTime', 'Saat seçin.');
            isValid = false;
        } else {
            const appointmentDate = new Date(data.date);
            const today = new Date();
            
            if (appointmentDate < today) {
                setFieldError('appointmentDate', 'Geçmiş tarih seçilemez.');
                isValid = false;
            }
            
            // Check if selected day is working day (Monday or Tuesday)
            const dayOfWeek = appointmentDate.getDay();
            if (dayOfWeek !== 1 && dayOfWeek !== 2) { // 1 = Monday, 2 = Tuesday
                setFieldError('appointmentDate', 'Sadece Pazartesi ve Salı günleri randevu alabilirsiniz.');
                isValid = false;
            }
        }
        
        // Validate service
        if (!data.service) {
            setFieldError('serviceType', 'Hizmet türü seçin.');
            isValid = false;
        }
        
        return isValid;
    }
    
    function validateField(field) {
        const value = field.value.trim();
        
        switch(field.id) {
            case 'customerName':
                if (value.length < 2) {
                    setFieldError(field.id, 'Ad soyad en az 2 karakter olmalıdır.');
                    return false;
                }
                break;
                
            case 'customerEmail':
                const emailPattern = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
                if (!emailPattern.test(value)) {
                    setFieldError(field.id, 'Geçerli bir e-posta adresi girin.');
                    return false;
                }
                break;
                
            case 'appointmentDate':
                if (!value) {
                    setFieldError(field.id, 'Tarih seçin.');
                    return false;
                }
                const selectedDate = new Date(value);
                const today = new Date();
                if (selectedDate < today) {
                    setFieldError(field.id, 'Geçmiş tarih seçilemez.');
                    return false;
                }
                break;
        }
        
        setFieldValid(field.id);
        return true;
    }
    
    function setFieldError(fieldId, message) {
        const field = document.getElementById(fieldId);
        field.classList.add('is-invalid');
        field.classList.remove('is-valid');
        
        // Show error message
        let errorDiv = field.parentNode.querySelector('.invalid-feedback');
        if (!errorDiv) {
            errorDiv = document.createElement('div');
            errorDiv.className = 'invalid-feedback';
            field.parentNode.appendChild(errorDiv);
        }
        errorDiv.textContent = message;
    }
    
    function setFieldValid(fieldId) {
        const field = document.getElementById(fieldId);
        field.classList.add('is-valid');
        field.classList.remove('is-invalid');
        
        // Remove error message
        const errorDiv = field.parentNode.querySelector('.invalid-feedback');
        if (errorDiv) {
            errorDiv.remove();
        }
    }
    
    function clearValidationStates() {
        const fields = appointmentForm.querySelectorAll('.form-control, .form-select');
        fields.forEach(field => {
            field.classList.remove('is-valid', 'is-invalid');
        });
        
        const errorDivs = appointmentForm.querySelectorAll('.invalid-feedback');
        errorDivs.forEach(div => div.remove());
    }
    
    function showError(message) {
        document.getElementById('errorMessage').textContent = message;
        errorModal.show();
    }
    
    function updateAvailableTimes(selectedDate) {
        // This function could be expanded to check available times via API
        // For now, we'll just ensure the selected date is a working day
        
        if (!selectedDate) return;
        
        const date = new Date(selectedDate);
        const dayOfWeek = date.getDay();
        
        // Reset time options
        timeSelect.innerHTML = '<option value="">Saat seçin...</option>';
        
        if (dayOfWeek === 1 || dayOfWeek === 2) { // Monday or Tuesday
            const workingHours = [
                '10:00', '11:00', '12:00', '13:00', 
                '14:00', '15:00', '16:00', '17:00'
            ];
            
            workingHours.forEach(time => {
                const option = document.createElement('option');
                option.value = time;
                option.textContent = time;
                timeSelect.appendChild(option);
            });
        } else {
            const option = document.createElement('option');
            option.value = '';
            option.textContent = 'Bu günde randevu alınmaz';
            option.disabled = true;
            timeSelect.appendChild(option);
        }
    }
    
    // Initialize page
    function init() {
        // Set focus on first input when appointment section comes into view
        const appointmentSection = document.getElementById('appointment');
        
        const observer = new IntersectionObserver((entries) => {
            entries.forEach(entry => {
                if (entry.isIntersecting) {
                    // Section is visible
                    document.getElementById('customerName').focus();
                }
            });
        }, { threshold: 0.5 });
        
        observer.observe(appointmentSection);
    }
    
    // Initialize the page
    init();
});

// Utility functions
function scrollToTop() {
    window.scrollTo({ top: 0, behavior: 'smooth' });
}

// Add scroll-to-top button
window.addEventListener('scroll', function() {
    const scrollButton = document.getElementById('scrollToTop');
    if (window.pageYOffset > 300) {
        if (!scrollButton) {
            createScrollToTopButton();
        }
    } else {
        if (scrollButton) {
            scrollButton.remove();
        }
    }
});

function createScrollToTopButton() {
    const button = document.createElement('button');
    button.id = 'scrollToTop';
    button.innerHTML = '<i class="fas fa-chevron-up"></i>';
    button.className = 'btn btn-primary position-fixed';
    button.style.cssText = 'bottom: 20px; right: 20px; z-index: 1000; border-radius: 50%; width: 50px; height: 50px;';
    button.onclick = scrollToTop;
    document.body.appendChild(button);
}
