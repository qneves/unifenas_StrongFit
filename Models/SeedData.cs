using ExemploEF.Models;
using Microsoft.EntityFrameworkCore;

namespace Strong_Fit.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            //associa os dados ao contexto
            Context context = app.ApplicationServices.GetRequiredService<Context>();
            //inserir os dados nas entidades do contexto
            context.Database.Migrate();
            //se o contexto estiver vazio
            if (!context.Personais.Any())
            //inserir os produtos iniciais
            {
                context.Personais.AddRange(
                    new Personal { Nome = "Carlos", Especialidade = "Musculação" },
                    new Personal { Nome = "Joao", Especialidade = "Musculação" },
                    new Personal { Nome = "Maria", Especialidade = "Musculação" },
                    new Personal { Nome = "Rosa", Especialidade = "Musculação" },
                    new Personal { Nome = "Lucas", Especialidade = "Musculação" }
                );

                context.Alunos.AddRange(
                    new Aluno { Nome = "Gabriel", Data_Nascimento = new DateTime(2004, 4, 19), Email = "gabriel@gmail.com", Instagram = "qneves", Telefone = "35988919140", PersonalID = 1, Observacoes = "obs" },
                    new Aluno { Nome = "Naty", Data_Nascimento = new DateTime(2003, 1, 17), Email = "naty@gmail.com", Instagram = "naty", Telefone = "1198888888", PersonalID = 2, Observacoes = "obs" }
                );


                context.Treinos.AddRange(
                    new Treino { PersonalID = 1, AlunoID = 1, Data = new DateTime(2024, 3, 19), Hora = new DateTime(1, 1, 1, 17, 0, 0)},
                    new Treino { PersonalID = 2, AlunoID = 2, Data = new DateTime(2024, 3, 18), Hora = new DateTime(1, 1, 1, 15, 0, 0)}
                );

                context.Exercicios.AddRange(
                    new Exercicio { Nome = "Exercicio 1", Descricao = "Descrição do exercicio", Categoria = "Musculação"},
                    new Exercicio { Nome = "Exercicio 2", Descricao = "Descrição do exercicio 2", Categoria = "Musculação"}
                );

                context.SaveChanges();
            }
        }
    }
}
