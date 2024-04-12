using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Test
{
    public static class test
    {
        public static void worldsdumbestfunction_ReturnsPikachu_ReturnsString()
        {
            try
            {
                //Arrange
                int num = 1;
                worldsdumbestfunction world = new worldsdumbestfunction();


                //Act
                String result = world.ReturnsPikachu(num);


                //Assert
                if(result == "Pikachu")
                {
                    Console.WriteLine("Passed: worldsdumbestfunction_ReturnsPikachu_ReturnsString ");

                }
                else
                {
                    Console.WriteLine("Failed :worldsdumbestfunction_ReturnsPikachu_ReturnsString");
                }


            }
            catch (Exception e) {
                Console.WriteLine(e.ToString());    
            }   
             
        }
    }
}
