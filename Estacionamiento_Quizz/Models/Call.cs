using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace Estacionamiento_Quizz.Models
{
    public class Call
    {
        List<Carros> carList;
        public Call(string dbPath) 
            
        {
           

            carList = new List<Carros>();
            
            
            var reader = new StreamReader(
                File.OpenRead(dbPath));

            
            while (!reader.EndOfStream)
            {
                
                var line = reader.ReadLine();
 
                
                var valores = line.Split(',');
                carList.Add(
                    new Carros
                    {
                        Matricula = valores[0],
                        Name = valores[1],
                        NoCtrl = valores[2],
                        Speciality = valores[3],
                        Semester = valores[4],
                        Photo = valores[5]
                    }
                  );                    
                      
            }


        }

        
        public Carros GetEmployeeById(string Matricula)
        {
            var carro = carList.Find(e => e.Matricula == Matricula);
            return carro;

        }
    }
}