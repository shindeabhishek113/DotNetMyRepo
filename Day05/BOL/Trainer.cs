namespace BOL;
using System.ComponentModel.DataAnnotations;

[Serializable]   
public class Trainer
{

[Required]

public int Id{get;set;}
public String Name{get;set;}
public String Email{get;set;}
public double Mobileno{get;set;}

public Trainer(){
    
}

public Trainer(int id,String name, String email,double mobileno){
    this.Id=id;
    this.Name=name;
    this.Email=email;
    this.Mobileno=mobileno;

}


}

