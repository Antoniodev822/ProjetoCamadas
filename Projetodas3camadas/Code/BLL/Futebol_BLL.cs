using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Projetodas3camadas.Code.DTO;

namespace Projetodas3camadas.Code.BLL
{
    class Futebol_BLL
    {
        public void inserir(Futebol_DTO futDTO)
        {

        }
    {
        public Datatable Listar() using system.data;
        {
        string sql = $"select = from {tabela} order by id;";
        return conexao.ExecutarConsulta(sql);
        
}
public void Editar(Futebol_DTO futdto)
{
 string alterar =$ "update {tabela} set nome = '{futdto.futebol_DTO}',posicao = '{futdto.posicao}' = '{futdto.id}';";
    conexao.ExecutarComando(alterar);
}

private void Excluir(Futebol_DTO futdto)
{
    string excluir = $"delete from{tabela} where id = '{futdto.id}';";
    conexao.ExecutarComando(excluir);


}
