function cheakTool() {
 var oUname = document.getElementById("uname")
    ChkName("借出人",oUname.value)
    if(document.getElementById("tool").value==5)
    {   

        ChkName("器材", document.getElementById("Location").value )
    }
    if(document.getElementById("day").value==15)
    {   

        ChkName("天數", document.getElementById("sday").value )
    }
    if(document.getElementById("brrrowtime").value==11)
    {
        var otherbrrrowtime = document.getElementById("otherbrrrowtime").value
        ChkName("數量", otherbrrrowtime)

    }

    alert("登記完成 ok");
        }

function ChkName(i,email) {
    var regex = /[^%&',;=?$x22]+/;
    if (!regex.test(email)) {
        alert(i+"輸入錯誤");
        return false;
        event.preventDefault();

    } else {
        return true;
    }
}

function TheConfirmBox() {
    　 let day =document.getElementById("day").value
    　 let sday =document.getElementById("sday")

        if(day == 15)
        {
            sday.style.display= "block";

        }
        else
        {
            sday.style.display= "none";
        }
     
    }

    function TheConfirmBox1() {
        　 let day =document.getElementById("tool").value
        　 let sday =document.getElementById("Location")
    
            if(day == 5)
            {
                sday.style.display= "block";
    
            }
            else
            {
                sday.style.display= "none";
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
    function ready() {
        var mydateInput = document.getElementById("time");
        var date = new Date();
        var yyyy = date.getFullYear(); //年
        var MM = (date.getMonth()+1<10 ? '0' : '')+(date.getMonth()+1);
        var dd = (date.getDate()<10 ? '0' : '')+date.getDate();
        dateString=yyyy+"-"+MM+"-"+dd;
        mydateInput.value = dateString;
    
    }
