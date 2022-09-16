using NLog;

namespace TP2Taller2.Clases{
    class Control{
        static public int IngresarNumPositivo()
        {
            var Logger = LogManager.GetCurrentClassLogger();
            int num = 0;
            bool error = true;
            
            while(error){
                try{
                    num = Int32.Parse(Console.ReadLine());
                    if (num < 0) throw new Exception("No se admiten números negativos");
                    error = false;
                }
                catch(Exception ex){
                    Logger.Error(ex);
                    Console.WriteLine("Ocurrió un error: " + ex.Message);
                }
            }

            return num;
        }

        static public string IngresarString(){
            string str = "";
            bool error = true;

            while(error){
                try{
                    str = Console.ReadLine();
                    if(str == "" || str == null) throw new ArgumentNullException(nameof(str));
                    error = false;
                }
                catch(Exception ex){
                    Console.WriteLine("Ocurrió un error: " + ex.Message);
                }
            }

            return str;
        }
    }
}