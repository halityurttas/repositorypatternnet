﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;


namespace RepositoryPattern.XMLSource
{
    public class XMLSet<TModel> where TModel : class
    {
        private string m_filename;
        private ICollection<TModel> m_models;

        public XMLSet(string FileName)
        {
            this.m_filename = FileName;
        }

        public ICollection<TModel> Data
        {
            get
            {
                try
                {
                    if (m_models == null) Load();
                }
                catch (Exception)
                {
                    m_models = new List<TModel>();
                }
                return m_models;
            }
            set
            {
                m_models = value;
                Save();
            }
        }

        public void Save()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<TModel>));
            StreamWriter sw = new StreamWriter(this.m_filename);
            serializer.Serialize(sw, this.m_models);
            sw.Close();
            sw.Dispose();
        }

        public void Load()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<TModel>));
            StreamReader sr = new StreamReader(this.m_filename);
            this.m_models = serializer.Deserialize(sr) as List<TModel>;
            sr.Close();
            sr.Dispose();
        }

    }
}
