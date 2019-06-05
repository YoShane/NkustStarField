function checkSingIn() {
    var oUname = document.getElementById("uname")
    var oUpass = document.getElementById("upass")
    if (oUname.value.length > 20 || oUname.value.length <= 6 || oUname.value == "學號") {
        alert("請在確認一次學號");
        event.preventDefault();
        return false;
    }
    else if (Chk(oUname.value)) {
        alert("帳號出現非法文字請檢查");
        event.preventDefault();
        return false;
    } else {
        oUname.innerHTML = oUname.value + "＠nkust.edu.tw";
        alert(oUname.value);
        return true;
    }
    
    
    if (oUpass.value.length > 20 || oUpass.value.length <= 6 || upass.value == "密碼") {
        alert("請在確認一次密碼");
        event.preventDefault();
        return false;

    } else if (Chk(upass.value)) {
        alert("密碼出現非法文字請檢查");
        event.preventDefault();
        return false;
    } 
   
}
function checkSingUp() {
    var oUname = document.getElementById("nname")
    var oUpass = document.getElementById("npass")
    var aUpass = document.getElementById("surenpass")

    if (oUname.value.length > 20 || oUname.value.length < 6 || oUname.value == "請輸入6-20位字元的帳號") {
        alert("請輸入6-20位字元的帳號");
        event.preventDefault();
        return false;
    }
    else if(Chk(oUname.value))
        {
            alert("帳號出現非法文字請檢查");

        event.preventDefault();
        return false;
        }
    
    
    if (oUpass.value.length > 20 || oUpass.value.length < 6 || upass.value == "請輸入6-20位字元的密碼") {
        alert("請輸入6-20位字元的密碼");
    }else if(Chk(upass.value))
    {
        alert("密碼出現非法文字請檢查");

        event.preventDefault();
        return false;
    }
    if(oUpass.value!=aUpass.value)
    {
        alert("與確認密碼不相符");
        event.preventDefault();
        return false;
    }


    if(checkPhone())
    {
        if(ChkName())
            return true;
    }
    
}

function checkPhone() {
    var phone = document.getElementById('phone').value;
    if (!(/^09[0-9]{8}$/.test(phone))) {
        alert(document.getElementById('phone').innerHTML = '請輸入正確的手機號');
        event.preventDefault();
        return false;

    } else { return document.getElementById('phone').innerHTML = 'ok'; }
}



function Chk(email) {
    var regex = /[^a-z^A-Z^0-9]/g;
    if (!regex.test(email)) {
        event.preventDefault();
        return false;
    } else {
        return true;
    }
}

function ChkName() {
    var oUpass = document.getElementById("chiname")
    var regex = /[^%&',;=?$x22]+/;
    if (!regex.test(oUpass)) {
        alert(oUpass+"請輸入格式");
        event.preventDefault();
        return false;
    } else {
        return true;
    }
}