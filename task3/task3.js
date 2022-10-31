var Num =5544;
var say =0;

for(i=0;i<Num; i++){
    Num /= 10;
    if(Num>0){
        say++;
    }
}console.log(say +1);