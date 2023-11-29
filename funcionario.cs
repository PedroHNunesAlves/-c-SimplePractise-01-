using System;
class Program {
    
    class Funcionario
    {
        
        private string _id;
        
        public string id
        {
            get
            {
                return _id;
            }
            
        }
        
        private string _nome;
        
        public string nome
        {
            
            get 
            {
                return _nome;
            }
            set 
            {
                 _nome = value;
            }
        }
        
        private double _salario;
        
        public double salario
        {
            get
            {
                return _salario;
            } 
            set 
            {
                 _salario = value;
            }
        }
        
        public Funcionario()
        {
            _id = Guid.NewGuid().ToString().Substring(0, 4).ToUpper();
        }
        
        public Funcionario(string id)
        {
            _id = id;
        }
        
    }
    
    
  static void Main()
  {
    
    Funcionario[] cadFunc = new Funcionario[2];
    
    for(int i=0; i < 2; i++)
    {
        
        Funcionario xFunc = new Funcionario();
        
        Console.WriteLine($"\nFuncionário {i + 1} - ID ({xFunc.id})");
        
        Console.Write("Digite o Nome..: ");
        xFunc.nome = Console.ReadLine();
        
        Console.Write("Digite o Salário..: ");
        xFunc.salario = double.Parse(Console.ReadLine());
        
        
        cadFunc[i] = xFunc;
    }
    
    Console.Clear();
    
    foreach(Funcionario F in cadFunc)
    {
        Console.WriteLine($"ID: {F.id} | Funcionario: {F.nome} | Salario: R${F.salario}  ");
    }

  }
}
