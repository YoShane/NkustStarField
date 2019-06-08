function checkSingIn() {
    var uidDomain = customizeDomain($("#uname").val());
    $("#uname").val(uidDomain);
    var oUpass = document.getElementById("upass")

    if (uidDomain.length >= 34 || uidDomain.length <= 18) {
        alert("請輸入6-20位字元的前綴帳號");
        event.preventDefault();
        return false;
    }
    
    
    if (oUpass.value.length > 100 || oUpass.value.length <= 6) {
        alert("密碼長度需6位以上");
        event.preventDefault();
        return false;

    } else if (Chk(upass.value)) {
        alert("密碼出現非法文字請檢查");
        event.preventDefault();
        return false;
    } 

    $("#account").submit();
    return true;
}

function checkSingUp() {
    var uidDomain = customizeDomain($("#nname").val());
    $("#nname").val(uidDomain);
    var oUpass = document.getElementById("npass")
    var aUpass = document.getElementById("surenpass")

    if (uidDomain.length >= 34 || uidDomain.length <= 18) {
        alert("請輸入6-20位字元的前綴帳號");
        event.preventDefault();
        return false;
    }

    if (oUpass.value.length > 100 || oUpass.value.length < 6) {
        alert("密碼長度需6位以上");
    } else if (Chk(oUpass.value))
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
        if (ChkName())
            $("#register").submit();
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

function Chk(email) {
    var regex = /[^a-z^A-Z^0-9]/g;
    if (!regex.test(email)) {
        event.preventDefault();
        return false;
    } else {
        return true;
    }
}
// =====================================
/* Config Setting: (取自第一校區 eSpace login page)
	(1) 以下兩個參數功能互斥，所以不應該兩個開關都是 true
	AUTO_ADD_DOMAIN 		=> 是否自動加上 "@domain" (若為true：如果用戶有輸入"@domain"將自動去掉，再自動加上正確的"@domain")
	AUTO_DELETE_DOMAIN 		=> 是否自動刪除 "@domain" (若為true：如果用戶有輸入"@domain"將自動去掉；若為否，系統則無任何動作)
	
	(2)	CUSTOM_DOMAIN 		=> 用戶的domain (請勿加上"@")
	(3) TEST_MODE			=> 是否為內部測試模式 (可於console查看Userid變化是否正確)
*/
var AUTO_ADD_DOMAIN = true; 			// "true" or "false"
var AUTO_DELETE_DOMAIN = false; 		// "true" or "false"
var CUSTOM_DOMAIN = "@nkust.edu.tw"; 	// just input String patten, EX:asuscloud.com
var TEST_MODE = false; 					// "true" or "false"
// =====================================

function customizeDomain(userid) {
    var log_text;
    log_text = "[Testing mode]" + "\n";
    log_text += "===== customizeDomain start =====" + "\n";
    log_text += "● Input Userid: " + userid + "\n\n";

    // setting domain
    var domain;
    if (CUSTOM_DOMAIN.indexOf("@") > -1)
        domain = CUSTOM_DOMAIN;
    else
        domain = "@" + CUSTOM_DOMAIN;

    log_text += "Config setting=>" + "\n";
    log_text += "○ AUTO_ADD_DOMAIN: " + AUTO_ADD_DOMAIN + "\n";
    log_text += "○ AUTO_DELETE_DOMAIN: " + AUTO_DELETE_DOMAIN + "\n";
    log_text += "○ CUSTOM_DOMAIN: " + CUSTOM_DOMAIN + "\n";
    log_text += "○ TEST_MODE: " + TEST_MODE + "\n\n";

    log_text += "Doing...modify login Userid..." + "\n";
    // modify login Userid
    var domainIndex = userid.indexOf("@");
    if (AUTO_ADD_DOMAIN) {
        if (domainIndex > -1) // if user has typed "@domain"
        {
            log_text += "○ User has typed '@domain'...so we need to delete '@domain' and add new '@domain'." + "\n";
            console.log();
            userid = userid.substring(0, domainIndex);
        }
        else {
            log_text += "○ User didn't type '@domain'. There is no need to do change Userid." + "\n";
        }
        userid += domain;
    }
    else if (AUTO_DELETE_DOMAIN) {
        if (domainIndex > -1) // if user has typed "@domain"
        {
            log_text += "○ User has typed '@domain'...so we need to delete '@domain'." + "\n";
            userid = userid.substring(0, domainIndex);
        }
    }
    else {
        //doing nothing
        log_text += "○ The config setting was all 'false', so System doing nothing." + "\n";
    }
    log_text += "\n" + "● Output Userid: " + userid + "\n";
    log_text += "===== customizeDomain end =====" + "\n";

    if (TEST_MODE) { alert(log_text); };

    return userid;
}