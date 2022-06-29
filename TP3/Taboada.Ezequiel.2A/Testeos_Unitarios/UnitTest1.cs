using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Excepciones;
using ControlArchivos;

namespace Testeos_Unitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Metodo_Sumar_ControlListas()
        {
            ControlListas<Cliente> clientes = new ControlListas<Cliente>();
            Cliente cliente = new Cliente("25487452", "Juan Lorenzo", "Gomez", "42584512");

            bool seAgrego;

            seAgrego = clientes + cliente;
            System.Console.WriteLine(seAgrego);
            Assert.IsTrue(seAgrego);
        }

        [TestMethod]
        public void Escritura_json_Ok()
        {
            bool sePudo;
            string ruta = "test.json";
            Cliente cliente = new Cliente("25487452", "Juan Lorenzo", "Gomez", "42584512");
            Serializador<Cliente> serializador = new Serializador<Cliente>(ETipoExtenxion.Json);

            sePudo = serializador.Escribir(ruta, cliente);

            Assert.IsTrue(sePudo);
        }

        [TestMethod]
        public void Lectura_json_Ok()
        {
            string ruta = "test.json";
            Cliente cliente = new Cliente("25487452", "Juan Lorenzo", "Gomez", "42584512");
            Serializador<Cliente> serializador = new Serializador<Cliente>(ETipoExtenxion.Json);
            Cliente otroCliente = null;

            if(serializador.Escribir(ruta, cliente))
            {
                otroCliente = serializador.Leer(ruta);
            }

            Assert.IsTrue(cliente.Equals(otroCliente));
        }

        [TestMethod]
        public void Escritura_Xml_Ok()
        {
            bool sePudo;
            string ruta = "test.xml";
            Cliente cliente = new Cliente("25487452", "Juan Lorenzo", "Gomez", "42584512");
            Serializador<Cliente> serializador = new Serializador<Cliente>(ETipoExtenxion.Xml);

            sePudo = serializador.Escribir(ruta, cliente);

            Assert.IsTrue(sePudo);
        }

        [TestMethod]
        public void Lectura_Xml_Ok()
        {
            string ruta = "test.xml";
            Cliente cliente = new Cliente("25487452", "Juan Lorenzo", "Gomez", "42584512");
            Serializador<Cliente> serializador = new Serializador<Cliente>(ETipoExtenxion.Xml);
            Cliente otroCliente = null;

            if (serializador.Escribir(ruta, cliente))
            {
                otroCliente = serializador.Leer(ruta);
            }

            Assert.IsTrue(cliente.Equals(otroCliente));
        }

        [ExpectedException(typeof(ExtensionInvalidaException))]
        [TestMethod]
        public void Lanzar_Excepcion_ErrorExtencion()
        {
            string ruta = "test.xml";
            string ruta2 = "test.json";
            Cliente cliente = new Cliente("25487452", "Juan Lorenzo", "Gomez", "42584512");
            Serializador<Cliente> serializador = new Serializador<Cliente>(ETipoExtenxion.Xml);
            Cliente otroCliente = null;

            if (serializador.Escribir(ruta, cliente))
            {
                otroCliente = serializador.Leer(ruta2);
            }
           
        }
    }
}
