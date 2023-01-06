namespace HR;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Security.Claims;
public  class User{
    private static string filename = @".\userdata1.json";
    public string FullName{get;set;}

    public string City{get;set;}

    public string Email{get;set;}

    public string Password{get;set;}


    public User(){

    }
    public User(string fullname, string city, string email, string password){
        this.FullName = fullname;
        this.City = city;
        this.Email = email;
        this.Password = password;
    }

     public User(string email, string password){
        this.Email = email;
        this.Password = password;
    }


    public bool Equals (object? obj){

        if(obj is User){
            return this.Email.Equals(((User)obj).Email) && this.Password.Equals(((User)obj).Password);
        }
    
        return false;
        
    }
    public  void saveUserData(List<User> userdata){
        
      //  User u = new User(fullname,city,email,password);
        // List<User> userdata = new List<User>();
        // userdata.Add(u);

        // var options = new JsonSerializerOptions{IncludeFields = true};
        // var dataJson = JsonSerializer.Serialize(userdata,options);

        // File.WriteAllText(filename,dataJson);

        var options = new JsonSerializerOptions { IncludeFields = true };
        var dataJson = JsonSerializer.Serialize(userdata, options);
        File.WriteAllText(filename, dataJson);
    }

    public List<User> restoreUserData(){

        string jsonString = File.ReadAllText(filename);
        List<User>? userd = JsonSerializer.Deserialize<List<User>>(jsonString);
        return userd;
    }
}