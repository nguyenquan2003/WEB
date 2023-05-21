function login() {
    var email = document.getElementById("email").value;
    var password = document.getElementById("password").value;
    var emailErrorMessage = document.getElementById("email-error-message");
    var passwordErrorMessage = document.getElementById("password-error-message");

    emailErrorMessage.innerHTML = "";
    passwordErrorMessage.innerHTML = "";

    if (email === ""||!email.includes("@")) {
        emailErrorMessage.innerHTML = "Vui lòng kiểm tra Email";
        return;
    }

    if (password.length < 10) {
        passwordErrorMessage.innerHTML = "Kiểm tra lại, mật khẩu phải từ 10 ký tự";
        return;
    }

    if (email === "yennh@hufi.edu.vn") {
        alert('Đăng nhập thành công');
        window.location.href = 'bai5b.html';
    }
    else{
        emailErrorMessage.innerHTML = "Email hoặc mật khẩu không đúng";
    }
}
