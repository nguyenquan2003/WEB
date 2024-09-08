function KiemTra()
{
    var flag = true;
    var emailPhone = document.getElementById("emailPhone").value;
    var errEmailPhone = document.querySelector(".errorEmailPhone");
    var pass=document.getElementById("passwd");
    var errPass= document.querySelector(".errorpass");
    var acc= document.querySelector(".account");
    if(emailPhone == "" || emailPhone.length < 10 || emailPhone.value == /^[0-9]+$/)
    {
        flag = false;
        errEmailPhone.textContent = "Vui lòng nhập Email/Số điện thoại phải hợp lệ!"
    }
    if(pass.value == ""||pass.value.length < 10)
    {
        flag = false;
        errPass.textContent = "Kiểm tra lại pass phải đủ 10 ký tự!"
    }
    if(flag == true){
        acc.textContent = emailPhone.value;
        document.getElementById("announce").style.display="block";
        document.getElementById("container").style.display="none";
    }
}