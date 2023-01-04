using BOL;
using System.Reflection;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;



Trainer trainer1 = new Trainer();
Trainer trainer2 = new Trainer(1,"Abhishek","shindeabhishek@gmail.com",9527145852);
Trainer trainer3 = new Trainer(2,"Ram","rambhau@gmail.com",5648956256);
Trainer trainer4 = new Trainer(3,"Sagar","sagarsatav@gmail.com",5548996554);

List<Trainer> trainer = new List<Trainer>();

trainer.Add(trainer1);
trainer.Add(trainer2);
trainer.Add(trainer3);
trainer.Add(trainer4);




    int choice= 1;

    while(choice<7 && choice>0){

        Console.WriteLine("\n\nEnter Operation: 1.Insert 2.Update 3.Delete 4.GetById 5.GetAll methods 6.Serialization-Deserialization 7.Exit");
 
        string choise_string = Console.ReadLine();
        choice = Convert.ToInt32(choise_string);

    switch(choice){

        case 1:
        Console.WriteLine("\nEnter details: Id, Name, Email, Mobile number respectively.");
        string tid_string= Console.ReadLine();
        int tid = Convert.ToInt32(tid_string);

        string tname= Console.ReadLine();
        string temail= Console.ReadLine();

        string tmobileno_string= Console.ReadLine();
        double tmobileno = double.Parse(tmobileno_string);

        Trainer traineradd = new Trainer(tid,tname,temail,tmobileno);
        trainer.Add(traineradd);
        break;

        case 2:
            Console.WriteLine("\nEnter Trainer id to Update: ");
            tid_string= Console.ReadLine();
            tid= Convert.ToInt32(tid_string);
            
            int index=-1;
        
            foreach( Trainer t in trainer)
            {
                index=index+1;
                if(t.Id == tid)
                {
                    break;
                } 
            } 

        Console.WriteLine("\nEnter Trainer Name, Email, Mobile number respectively to Update: \nNote: If you dont want to update any field just press enter to move forward");
        
        tname= Console.ReadLine();
        if(tname.Length != 0)
        {
            trainer[index].Name= tname;
        }

        temail= Console.ReadLine();
        if(temail.Length != 0)
        {
            trainer[index].Email= temail;
        }

        tmobileno_string= Console.ReadLine();
        if(tmobileno_string.Length != 0)
        {
           tmobileno = double.Parse(tmobileno_string);
            trainer[index].Mobileno= tmobileno;
        }
        break;

        case 3:
            Console.WriteLine("\nEnter Trainer id to delete: ");
            tid_string= Console.ReadLine();
            tid = Convert.ToInt32(tid_string);
            
            index=-1;
        
            foreach( Trainer t in trainer)
            {
                index=index+1;
                if(t.Id == tid)
                {
                    break;
                } 
            }  

            trainer.RemoveAt(index);

        break;

        case 4:
            Console.WriteLine("\nEnter Trainer id to get details: ");
            tid_string= Console.ReadLine();
            tid = Convert.ToInt32(tid_string);
        
            foreach( Trainer t in trainer)
            {
                if(t.Id == tid)
                {
                    Console.WriteLine($"{t.Id} {t.Name}  {t.Email}  {t.Mobileno}");  
                }   
            }  
        break;

        case 5:
            Console.WriteLine("\nPrinting all methods:");

            string path=@"D:\7. VS DotNet Data\dotnet\LabPractice\Day05\TestBOL\bin\Debug\net7.0\BOL.dll";
            Assembly asm=Assembly.LoadFile(path);
            string name=asm.FullName;
            Console.WriteLine(name);

            Type[] types=asm.GetTypes();

            for( int i=0;i<types.Count();i++){
                string typeName=types[i].Name;
                Console.WriteLine(typeName);
                MethodInfo [] mi=types[i].GetMethods();
                foreach( MethodInfo m in mi){
                  string methodName=m.Name;
                  Console.WriteLine(methodName);
                }
            }

        break;

        case 6:
            try{
            var options=new JsonSerializerOptions {IncludeFields=true};
            var TrainerJson=JsonSerializer.Serialize<List<Trainer>>(trainer,options);
            string fileName=@"d:\abhi\Trainer.json";
            File.WriteAllText(fileName,TrainerJson);

            string jsonString = File.ReadAllText(fileName);
            List<Trainer> jsonTrainers = JsonSerializer.Deserialize<List<Trainer>>(jsonString);
            Console.WriteLine("\nDeserializing data from json file");
            foreach( Trainer t in jsonTrainers)
            {
                Console.WriteLine($"{t.Id} {t.Name}  {t.Email}  {t.Mobileno}");   
            }   
          }
            catch(Exception exp){}
             finally{}
        break;

        

    }

    }


