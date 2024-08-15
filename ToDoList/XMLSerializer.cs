using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ToDoList
{
    public class XMLSerializer
    {
        public void Serialize(string path, object obj)
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(obj.GetType());

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            XmlWriter writer = XmlWriter.Create(path, settings);

            serializer.Serialize(writer, obj);

            writer.Close();
            writer.Dispose();
        }

        public object Deserialize(string path, Type type) 
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(type);

            XmlReader reader = XmlReader.Create(path);

            object obj = serializer.Deserialize(reader);

            reader.Close();
            reader.Dispose();

            return obj;
        }

        public void Serialize<T>(string path, T obj)
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            XmlWriter writer = XmlWriter.Create(path, settings);

            serializer.Serialize(writer, obj);

            writer.Close();
            writer.Dispose();
        }

        public T Deserialize<T>(string path)
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));

            XmlReader reader = XmlReader.Create(path);

            object obj = serializer.Deserialize(reader);

            reader.Close();
            reader.Dispose();

            return (T)obj;
        }

    }
}
