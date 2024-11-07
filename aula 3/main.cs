using System;
class Carro{
  //Propriedades do carro
  public string Marca {get;set;}
  public string Modelo {get;set;}

  public void ExibirInfo(){
    Console.WriteLine($"Carro: {Marca} {Modelo}");
  }
}


class Program {
  public static void Main (string[] args) {

    Carro meuCarro = new Carro();
    meuCarro.Marca = "Toyota";
    meuCarro.Modelo = "Corolla";


    //Chamando o método do objeto
    meuCarro.ExibirInfo();
    
   
  }
}