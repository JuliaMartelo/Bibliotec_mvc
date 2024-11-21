using Microsoft.EntityFrameworkCore;
using Bibliotec.Models;

namespace Bibliotec.Contexts
{
    //Classe que tera as infomracoes do banco de dados
    public class Context : DbContext
    {
        //Criar um metodo construtor
        public Context()
        {

        }

        public Context(DbContextOptions<Context> options) : base
        (options)
        {

        }

        //OnConfiguring -> Possui a configuracao da conexao com o banco de dados

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Colocar as informacoes do banco
            // As informacoes existem?

            if (!optionsBuilder.IsConfigured)
            {
                //A string de conexao do banco de dados:
                // Data Source => Nome do servidor do banco de dados
                //Initial Catalog => Nome do Banco de dados
                //User Id e Passaword => Informacoes de acesso ao servidor do banco de dados
                optionsBuilder.UseSqlServer(@"
                Data Source = NOTE29-S28\\SQLEXPRESS; 
                Initial Catalog = Bibliotec_mvc ;
                User Id=sa; Passaword=123 ; 
                Integrated Security=true ; 
                TrusServerCertificate = true");
            }
        }
   
        public DbSet <Categoria> Categoria { get; set; }
        public DbSet <Curso> Curso { get; set; }
        public DbSet <Livro> Livro { get; set; }
        public DbSet <Usuario> Usuario { get; set; }
        public DbSet <LivroCategoria> LivroCategoria { get; set; }
        public DbSet <LivroReserva> LivroReserva { get; set; }

    }
}

