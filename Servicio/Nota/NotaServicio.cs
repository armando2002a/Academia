﻿using Repositorios.Nota;

namespace Servicio.Nota
{
    public class NotaServicio : INotaServicio
    {
        private readonly INotaRepositorio _notaRepositorio;

        public NotaServicio(INotaRepositorio notaRepositorio)
        {
            _notaRepositorio = notaRepositorio;
        }

        public List<Datos.Models.Nota> ListaNota() => _notaRepositorio.ListaNota();

        public List<Datos.Models.MostrarNotasMaestro> ListaNotaMaestro(int EstudianteID) => _notaRepositorio.ListaNotaMaestro(EstudianteID);

        public List<Datos.Models.NotaPorEstudiante> ListaNotaClase(int EstudianteID) => _notaRepositorio.ListaNotaClase(EstudianteID);

        public List<Datos.Models.Nota> ListaNotaPorID(int NotaID) => _notaRepositorio.ListaNotaPorID(NotaID);

        public bool GuardarNota(Datos.Models.Nota Nota) => _notaRepositorio.GuardarNota(Nota);

        public bool ActualizarNota(Datos.Models.Nota Nota) => _notaRepositorio.ActualizarNota(Nota);
    }
}
