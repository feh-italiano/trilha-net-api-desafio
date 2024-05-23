using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using trilha_net_api_desafio_novo.Controllers;
using trilha_net_api_desafio_novo.Models;

namespace trilha_net_api_desafio_novo.Context
{
    public class OrganizadorContext : DbContext
    {
        public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options) {}

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}