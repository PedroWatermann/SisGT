using SisGT.Controllers;
using SisGT.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace SisGTTest
{
    [TestClass]
    public sealed class SisGTTest
    {
        private TaskController _controller;
        private TaskModel _repo;

        [TestInitialize]
        public void Setup()
        {
            _repo = new TaskModel()
            {
                Id = 1,
                Title = "Test Task",
                Description = "This is a test task",
                Status = false
            };
            _controller = new TaskController();
        }

        [TestMethod]
        public void CriarTarefa_DeveAdicionarNaLista()
        {
            _controller.Create(_repo);

            var tarefas = _controller.Read();
            Assert.AreEqual(1, tarefas.Count);
            Assert.AreEqual("Test Task", tarefas.First().Title);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CriarTarefa_TituloVazio_DeveLancarExcecao()
        {
            _controller.Create(new TaskModel());
        }

        [TestMethod]
        public void ConcluirTarefa_DeveAlterarStatusParaConcluida()
        {
            _controller.Create(_repo);
            var tarefa = _controller.Read().First();

            _controller.Update(tarefa, tarefa.Id);

            var tarefaAtualizada = _controller.Read().First();
            Assert.AreEqual(true, tarefaAtualizada.Status);
        }

        [TestMethod]
        public void RemoverTarefa_DeveExcluirDaLista()
        {
            _controller.Create(_repo);
            var tarefa = _controller.Read().First();

            _controller.Delete(tarefa.Id);

            Assert.AreEqual(0, _controller.Read().Count);
        }
    }
}
