function KiemTra(){
    var flag = true;
    var mail=document.getElementById("email");
    var pass=document.getElementById("passwd");
    var errMail= document.querySelector(".erroremail");
    var errPass= document.querySelector(".errorpass");
    var phoneNumber = document.getElementById("phone");
    var errPhone = document.querySelector(".errorphone");
    var rePass = document.getElementById("repasswd");
    var errRePass = document.querySelector(".errorRepass");
    var acc= document.querySelector(".account");
    if(phoneNumber.value == "" ||  !/^[0-9]+$/ || phoneNumber.value.length < 10)
    {
        flag = false;
        errPhone.textContent = "Vui lòng kiểm tra lại số điện thoại!"
    }
    if(mail.value == ""||mail.value.length < 10)
    {
        flag = false;
        errMail.textContent = "Vui lòng kiểm tra lại Email phải hợp lệ!"
    }
    if(pass.value == ""||pass.value.length < 10 || rePass.value != pass.value)
    {
        flag = false;
        errPass.textContent = "Kiểm tra lại mật khẩu phải 10 ký tự!"
    }
    if(rePass.value == "" || rePass.value != pass.value || rePass.value.length < 10)
    {
        flag = false;
        errRePass.textContent = "Mật khẩu xác nhận không hợp lệ!"
    }
    if(flag == true){
        acc.textContent = mail.value;
        document.getElementById("announce").style.display="block";
        document.getElementById("container").style.display="none";
     }
    }    