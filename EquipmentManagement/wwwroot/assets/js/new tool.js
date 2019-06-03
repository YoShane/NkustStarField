function cheakTool() {
    var script = document.getElementById("script").value
    var Price_merber = document.getElementById("Price_merber").value
    var Price_non_merber = document.getElementById("Price_non_merber").value
    var Special = document.getElementById("Special1").value
    if(document.getElementById("toolkind").value==other)
    {
        var toolkindOther = document.getElementById("toolkindOther").value
        ChkName(" 新器材種類", toolkindOther)
    }
    if(document.getElementById("brrrowtime").value==11)
    {
        var otherbrrrowtime = document.getElementById("otherbrrrowtime").value
        ChkName("數量", otherbrrrowtime)
    }
    if(document.getElementById("SourceTool").value==15)
    {
        var additionaltool = document.getElementById("additionaltool").value
        ChkName("來源", additionaltool)
    }
    if(document.getElementById("ToolLocation").value!= "otherlocal")
    {
        var OtherToolLocation = document.getElementById("OtherToolLocation").value
        ChkName("存放地", OtherToolLocation)
    }
    ChkName("價值", script)
    ChkName("社員租金 ", Price_merber)
    ChkName("非社員租金", Price_non_merber)
    ChkName("註備", Special)



}

function cheakToolkind() {
    var toolkind = document.getElementById("toolkind").value
    let sday = document.getElementById("toolkindOther")

    if (toolkind == "other") {
        sday.style.display = "block";

    }
    else {
        sday.style.display = "none";
    }

}

function ChkName(i, email) {
    var regex = /[^%&',;=?$x22 ]+/;
    if (!regex.test(email)) {
        alert(i + "輸入錯誤");
        return false;
        event.preventDefault();

    } else {
        return true;
    }
}

function TheConfirmBox() {
    let day = document.getElementById("SourceTool").value
    let sday = document.getElementById("additionaltool")
    let money = document.getElementById("money")


    if (day == 15) {
        sday.style.display = "block";
        return false;


    }
    else {
        sday.style.display = "none";

    }
    if (day != "don") {
        money.style.display = "block";
        return false;


    }
    else {
        money.style.display = "none";

    }
    

}
function TheConfirmBox2() {

    let brrrowtime = document.getElementById("brrrowtime").value

    if (brrrowtime == 11) {
        document.getElementById("otherbrrrowtime").style.display = "block";
        return false;
    }
    else {
        document.getElementById("otherbrrrowtime").style.display = "none";

    }

}
function TheConfirmBox3() {

    let brrrowtime = document.getElementById("ToolLocation").value

    if (brrrowtime == "otherlocal") {
        document.getElementById("OtherToolLocation").style.display = "block";
        return false;
    }
    else {
        document.getElementById("OtherToolLocation").style.display = "none";

    }
    
}

function ready() {
    var mydateInput = document.getElementById("time");
    var date = new Date();
    var yyyy = date.getFullYear(); //年
    var MM = (date.getMonth()+1<10 ? '0' : '')+(date.getMonth()+1);
    var dd = (date.getDate()<10 ? '0' : '')+date.getDate();
    dateString=yyyy+"-"+MM+"-"+dd;
    mydateInput.value = dateString;

}
