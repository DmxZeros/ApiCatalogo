using Microsoft.EntityFrameworkCore.Migrations;

namespace APICatalogo.Migrations
{
    public partial class PopulaDb : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO CATEGORIAS(NOME, IMAGEMURL) VALUES('Bebidas', 'http://www.macoratti.net/imagens/1.jpg')");
            mb.Sql("INSERT INTO CATEGORIAS(NOME, IMAGEMURL) VALUES('Lanches', 'http://www.macoratti.net/imagens/2.jpg')");
            mb.Sql("INSERT INTO CATEGORIAS(NOME, IMAGEMURL) VALUES('Sobremesas', 'http://www.macoratti.net/imagens/3.jpg')");

            mb.Sql("INSERT INTO PRODUTOS(NOME, DESCRICAO, PRECO, IMAGEMURL, ESTOQUE, DATACADASTRO, CATEGORIAID) " +
                " VALUES ('Coca-Cola', 'Refrigerante de 350 ml', '4.45', 'http://www.macoratti.net/imagens/COCA.jpg', 50, getdate(), " +
                "(SELECT CategoriaId FROM CATEGORIAS WHERE NOME='Bebidas'))");

            mb.Sql("INSERT INTO PRODUTOS(NOME, DESCRICAO, PRECO, IMAGEMURL, ESTOQUE, DATACADASTRO, CATEGORIAID) " +
                " VALUES ('Lanche de Atum', 'Lanche de Atum com maionese', '8.50', 'http://www.macoratti.net/imagens/ATUM.jpg', 50, getdate(), " +
                "(SELECT CategoriaId FROM CATEGORIAS WHERE NOME='Lanches'))");

            mb.Sql("INSERT INTO PRODUTOS(NOME, DESCRICAO, PRECO, IMAGEMURL, ESTOQUE, DATACADASTRO, CATEGORIAID) " +
                " VALUES ('Pudim 100g', 'Pudim de leite condensado 100g', '6.70', 'http://www.macoratti.net/imagens/PUDIM.jpg', 50, getdate(), " +
                "(SELECT CategoriaId FROM CATEGORIAS WHERE NOME='Sobremesas'))");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Categorias");
            mb.Sql("Delete from Produtos");
        }
    }
}
