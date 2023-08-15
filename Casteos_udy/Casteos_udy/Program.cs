//CASTEOS, conversiones
//convertir  las variables

var cant1 = 7;
var cant2 = 4;
//casteo explicicto (porque se hace manualmente)
var div = (double) cant1 / cant2;

Console.WriteLine("La division es: " + div);

//ejemplo 2

byte byte1; //0 a 255,  hay que tener cuidado por el posible overflow
int int1=3;

checked{
    byte1=(byte)int1;
}
Console.WriteLine(byte1);

//ejemplo 3 casteo implicito

byte byte2 = 11;
int int2 ;
//casteo implicito
int2 = byte2;
Console.WriteLine(int2);