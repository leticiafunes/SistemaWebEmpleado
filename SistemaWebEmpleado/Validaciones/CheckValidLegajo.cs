using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Logging;

namespace WebEscuelaMVC.Validation
{
    public class CheckValidLegajo : ValidationAttribute
    {

        public CheckValidLegajo()
        {

            ErrorMessage = "El legajo tiene el formato AA11111"; 

        }
        public override bool IsValid(object value)
        {
            string legajo = (string)value;
            string letras = legajo.Substring(0, 1);


            if (letras == "AA")
            {
                int num;
                bool invalido = false;

                for (var i = 2; i < 7; i++)
                {
                    try
                    {
                        num = Int32.Parse(legajo[i].ToString());
                    }
                    catch
                    {
                        invalido = true;
                    }


                }

                if (invalido)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            else {
                return true;
            }

            

        }

    }
}