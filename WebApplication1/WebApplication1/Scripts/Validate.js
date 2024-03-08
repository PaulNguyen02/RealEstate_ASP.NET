function validatePassword(password1, password2) {
    var pass2 = document.getElementById("password2").value;
    var pass1 = document.getElementById("password1").value;
    if (pass1 != pass2)
        //document.getElementById("password2").setCustomValidity("Passwords Don't Match");
        return false;
    else
        return true;
    //empty string means no validation error
}
function validateEmail(email) {
    const regex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    return regex.test(email);
}

function validatePhoneNumber(phoneNumber) {
    // Remove any non-digit characters from the phone number
    const cleanedPhoneNumber = phoneNumber.replace(/\D/g, '');

    // Check if the cleaned phone number is 10 digits long
    if (cleanedPhoneNumber.length == 10) {
        return true;
    } else {
        return false;
    }
}
