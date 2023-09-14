let input = document.getElementById("inputbox");
let buttons = document.getElementById("button");

let string="";
let arr= Array.from(buttons);
arr.forEach(button =>{
    button.addEventListener('Click', (e)=>{
        if(e.target.innerHTML=='='-)
        string = eval(string)
        imput.value = string
    }
    )
else.if(e.target.innerHTML==AC){
    string="";
    input.value=string;
}

