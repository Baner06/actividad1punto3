using System;

namespace informacion_financiera
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string tipoCuenta;
            decimal numeroCuenta;
            decimal saldo;
            decimal consignacion;
            decimal retiro;
            decimal cantidad;


            Console.WriteLine("Digite Su Nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Digite su numero de documento");
            numeroCuenta = Convert.ToDecimal(Console.ReadLine());


            Console.WriteLine("escoga la accion que desea hacer: \n    1   consignar dinero \n    2   retirar dinero");
            retiro = Convert.ToDecimal(Console.ReadLine());

            if (retiro.Equals("1"))
                Console.WriteLine("escriba el Tipo de Cuenta que desea consignar \n    ahorro\n    corriente\n    nomina");
                tipoCuenta = Console.ReadLine();

            if (tipoCuenta.Equals("ahorro"))
                Console.WriteLine("tipo de cuenta ahorro selecionada\n   su saldo actual es de:\n  $ 0.00");
                Console.WriteLine("digite la cantidad desea consignar");
                consignacion = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine($"usted consigno: ${consignacion}  exitosamente.");

            if (tipoCuenta.Equals("corriente"))
                Console.WriteLine("tipo de cuenta corriente selecionada\n   su saldo actual es de:\n  $ 0.00");
                Console.WriteLine("digite la cantidad desea consignar");
                consignacion = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine($"usted consigno: ${consignacion}  exitosamente.");


            if (tipoCuenta.Equals("nomina"))
                Console.WriteLine("tipo de cuenta nomina seleccionada\n   su saldo actual es de:\n  $ 0.00");
                Console.WriteLine("digite la cantidad desea consignar");
                consignacion = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine($"usted consigno: ${consignacion}  exitosamente.");

            if (retiro.Equals("2"))
                Console.WriteLine("digite la cantidad deseada a retirar");
                cantidad = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine($"el retiro fue un exito, usted retiro: ${cantidad} ");



            


                saldo = consignacion + cantidad;


                //Console.WriteLine("escriba el Tipo de Cuenta que desea consignar \n   ahorro\n   corriente\n   nomina");
            //tipoCuenta = Console.ReadLine();

            //if (tipoCuenta.Equals("ahorro"))
                //Console.WriteLine("tipo de cuenta ahorro selecionada\n   su saldo es de:\n  $ 0.00");


            //else if (tipoCuenta.Equals("corriente"))
                //Console.WriteLine("tipo de cuenta corriente selecionada\n   su saldo es de:\n  $ 0.00");

            //else if (tipoCuenta.Equals("nomina"))
                //Console.WriteLine("tipo de cuenta nomina seleccionada\n   su saldo es de:\n  $ 0.00");
            //else 
                //Console.WriteLine("Error en los datos ingresados.");

            //if accion 
            
            //Console.WriteLine("ingrese el valor a consignar:");
            //consignacion = Convert.ToDecimal(Console.ReadLine());


                Console.WriteLine($"Su numero de Cuenta es {numeroCuenta}\n  su tipo de cuenta es {tipoCuenta}\n   su nombre es {nombre} \n  la cantidad de dinero con la que cuentas es {saldo} ");


            
        }
    }
}
