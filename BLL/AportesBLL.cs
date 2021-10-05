﻿using Microsoft.EntityFrameworkCore;
using P1_AP1_Alvaro_20190269.DAL;
using P1_AP1_Alvaro_20190269.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace P1_AP1_Alvaro_20190269.BLL
{
    public class AportesBLL
    {
        public static bool Guardar(Aportes aporte)
        {
            if (!Existe(aporte.AporteID))
                return Insertar(aporte);
            else
                return Modificar(aporte);
        }

        public static bool Insertar(Aportes aporte)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Aportes.Add(aporte);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static bool Modificar(Aportes aporte)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(aporte).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                var aporte = contexto.Aportes.Find(id);

                if (aporte != null)
                {
                    contexto.Aportes.Remove(aporte);
                    paso = contexto.SaveChanges() > 0;
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;
            try
            {
                encontrado = contexto.Aportes.Any(e => e.AporteID == id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return encontrado;
        }

        public static Aportes Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Aportes aporte;
            try
            {
                aporte = contexto.Aportes.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return aporte;
        }

        public static List<Aportes> GetList(Expression<Func<Aportes, bool>> criterio)
        {
            List<Aportes> lista = new List<Aportes>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Aportes.Where(criterio).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }

        public static List<Aportes> GetAporte()
        {
            List<Aportes> lista = new List<Aportes>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Aportes.ToList();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return lista;
        }
    }
}