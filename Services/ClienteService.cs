using teste_vs.Database;
using teste_vs.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;


namespace teste_vs.Services
{
    internal class ClienteService
    {

        private readonly AppDbContext _context;

        public ClienteService(AppDbContext context) // esta construindo a classe que seja a porta de entrada do banco. 
        {
            _context = context; // aqui esta definindo que sempre que eu usar _context eu irei usar o banco de dados
        }
        public List<Cliente> GetAllClientes() // aqui gera uma lista com todos os clientes
        {
            return _context.Clientes.ToList(); // ao usar o _context, vai buscar na tabela cliente, todos os clientes e enviar para a lista
        }

        public void AddClientes(Cliente cliente) // estou definindo o metodo de adição de cliente
        {
            _context.Clientes.Add(cliente); // conecta ao banco e adiciona cliente
            _context.SaveChanges(); //salva no banco as alterações
        }
        public Cliente GetClienteByID(int id) // ira buscar o cliente por ID
        {
            return _context.Clientes.FirstOrDefault(c => c.ID == id); // isso quer dizer que vai retornar o primeiro ID que foi procurado, caso nao haja nenhum, vai retornar NULL
        }

        public void UpdateCliente(Cliente cliente)
        {
            _context.Clientes.Update(cliente); // isso fara conexao e ira fazer update do cliente
            _context.SaveChanges();
        }

        public void DeleteCliente(int id)
        {
            var cliente = _context.Clientes.FirstOrDefault(c => c.ID == id); // busca o cliente pelo ID e define
            if (cliente != null) // caso nao seja nulo
            {
                _context.Clientes.Remove(cliente); // ira ser removido do banco.
                _context.SaveChanges();
            }
        }
    }
}
