function cheakTool() {
 var oUname = document.getElementById("uname")

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
  
        }
     
    

    function TheConfirmBox1() {

        
        }
    function ready() {
        var mydateInput = document.getElementById("datetime");
        var date = new Date();
        var yyyy = date.getFullYear(); //年
        var MM = (date.getMonth()+1<10 ? '0' : '')+(date.getMonth()+1);
        var dd = (date.getDate()<10 ? '0' : '')+(date.getDate()+1);
        dateString=yyyy+"-"+MM+"-"+dd;
        mydateInput.value = dateString;
    
    }
    function changetime() {
        var time = document.getElementById("changetime1")
        var ontime = document.getElementById("time")

        var date = new Date();

        if(time.value==0)
        {
            ontime.value="12:30";
        }
        if(time.value==1)
        {
            ontime.value="08:00";
        }
        if(time.value==2)
        {
            ontime.value="09:00";
        }
        if(time.value==3)
        {
            ontime.value="10:00";
        }
        if(time.value==4)
        {
            ontime.value="11:00";
        }        

        if(time.value==5)
        {
            ontime.value="14:20";
        }
        if(time.value==6)
        {
            ontime.value="15:20";
        }
        if(time.value==7)
        {
            ontime.value="16:20";
        }
        if(time.value==8)
        {
            ontime.value="17:20";
        }
        
        if(time.value==10)
        {
            ontime.value="18:20";
        }
    }

