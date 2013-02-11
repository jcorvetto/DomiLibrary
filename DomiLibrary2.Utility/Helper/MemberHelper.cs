﻿
namespace DomiLibrary.Utility.Helper
{
    /// <summary>
    /// Clase encargada de proporcionar utilidades para los atributos de las funciones/metodos/entidades
    /// </summary>
    public class MemberHelper
    {
        /// <summary>
        /// Funcion que devuelve el nombre del parametro de la funcion/metodo
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="expr"></param>
        /// <returns></returns>
        public static string GetNameParameter(string expr)
        {
            //var body = ((MemberExpression)expr.Body);
            //return body.Member.Name;

            return expr;
        }
    }
}
