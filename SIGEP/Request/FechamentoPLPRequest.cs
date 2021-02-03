using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using CorreiosAPI.SIGEP.Data;
using CorreiosAPI.SIGEP.Enum;
using CorreiosAPI.SIGEP.Interfaces;

namespace CorreiosAPI.SIGEP.Request {
    public class FechamentoPLPRequest : ISIGEPRequest {
        public long IdPlpCliente { get; set; }
        public string CartaoPostagem { get; set; }
        public IntervaloEtiquetas Etiquetas { get; set; }
        public FechamentoPLP FechamentoPLP { get; set; }

        public XElement XML(string usuario, string senha, XNamespace cli) {
            return null;
        }

        private XDocument PlpXml() {
            return new XDocument(
                new XDeclaration("1.0", "ISO-8859-1", "yes"),

                new XElement("correioslog",
                    new XElement("tipo_arquivo",   "Postagem"),
                    new XElement("versao_arquivo", "2.3"),

                    XML(FechamentoPLP.PreListaPostagem),
                    XML(FechamentoPLP.Remetente),
                    XML(FechamentoPLP.FormaPagamento),
                    XML(FechamentoPLP.ObjetosPostais)
                )
            );
        }

        private XElement XML(PreListaPostagem plp) {
            return new XElement("plp",
                new XElement("id_plp"),
                new XElement("valor_global"),
                new XElement("mcu_unidade_postagem"),
                new XElement("nome_unidade_postagem"),

                new XElement("cartao_postagem", CartaoPostagem)
            );
        }

        private XElement XML(Remetente remetente) {
            return new XElement("remetente",
                new XElement("numero_contrato",           remetente.NumeroContrato),
                new XElement("numero_diretoria",          remetente.NumeroDiretoria),
                new XElement("codigo_administrativo",     remetente.CodigoAdministrativo),
                new XElement("nome_remetente",            CDATA(remetente.Nome)),
                new XElement("logradouro_remetente",      CDATA(remetente.Endereco.Logradouro)),
                new XElement("numero_remetente",          CDATA(remetente.Endereco.Numero)),
                new XElement("complemento_remetente",     CDATA(remetente.Endereco.Complemento)),
                new XElement("bairro_remetente",          CDATA(remetente.Endereco.Bairro)),
                new XElement("cep_remetente",             CDATA(remetente.Endereco.Cep)),
                new XElement("cidade_remetente",          CDATA(remetente.Endereco.Cidade)),
                new XElement("uf_remetente",              CDATA(remetente.Endereco.Uf)),
                new XElement("telefone_remetente",        CDATA(remetente.Contato.Telefone)),
                new XElement("fax_remetente",             CDATA(remetente.Contato.Fax)),
                new XElement("email_remetente",           CDATA(remetente.Contato.Email)),
                new XElement("celular_remetente",         CDATA(remetente.Contato.Celular)),
                new XElement("cpf_cnpj_remetente",        remetente.CpfCnpj),
                new XElement("ciencia_conteudo_proibido", remetente.CienciaConteudoProibido ? "S" : "N")
            );
        }

        private XElement XML(FormaPagamentoCorreios? formaPagamento) {
            if (formaPagamento == null)
                return new XElement("forma_pagamento");

            return new XElement("forma_pagamento", (int)formaPagamento.GetValueOrDefault());
        }

        private List<XElement> XML(List<ObjetoPostal> objetos)
            => objetos.Select(o => XML(o)).ToList();

        private XElement XML(ObjetoPostal objeto) {
            var dimensoes = objeto.Embalagem.Dimensoes();

            return new XElement("objeto_postal",
                new XElement("numero_etiqueta",         objeto.Etiqueta.StrComDv()),
                new XElement("codigo_servico_postagem", objeto.ServicoPostagem.Codigo),
                new XElement("peso",                    objeto.PesoGramas),
                new XElement("rt1",                     CDATA(objeto.ObservacoesCliente)),
                new XElement("restricao_anac",          objeto.CienciaConteudoProibido ? "S" : "N"),
                new XElement("cubagem",                 "0,00"),
                new XElement("status_processamento",    "0"),
                new XElement("data_postagem_sara"),
                new XElement("codigo_objeto_cliente"),
                new XElement("numero_comprovante_postagem"),
                new XElement("valor_cobrado"),

                new XElement("destinatario",
                    new XElement("nome_destinatario",        CDATA(objeto.Destinatario?.Nome)),
                    new XElement("telefone_destinatario",    CDATA(objeto.Destinatario?.Contato?.Telefone)),
                    new XElement("celular_destinatario",     CDATA(objeto.Destinatario?.Contato?.Celular)),
                    new XElement("email_destinatario",       CDATA(objeto.Destinatario?.Contato?.Email)),
                    new XElement("logradouro_destinatario",  CDATA(objeto.Destinatario?.Endereco?.Logradouro)),
                    new XElement("complemento_destinatario", CDATA(objeto.Destinatario?.Endereco?.Complemento)),
                    new XElement("numero_end_destinatario",  CDATA(objeto.Destinatario?.Endereco?.Numero)),
                    new XElement("cpf_cnpj_destinatario",    objeto.Destinatario?.CpfCnpj)
                ),

                new XElement("nacional",
                    new XElement("bairro_destinatario",   CDATA(objeto.Destinatario?.Endereco?.Bairro)),
                    new XElement("cidade_destinatario",   CDATA(objeto.Destinatario?.Endereco?.Cidade)),
                    new XElement("uf_destinatario",       CDATA(objeto.Destinatario?.Endereco?.Uf)),
                    new XElement("cep_destinatario",      CDATA(objeto.Destinatario?.Endereco?.Cep)),
                    new XElement("codigo_usuario_postal", objeto.Nacional?.CodigoUsuarioPostal),
                    new XElement("centro_custo_cliente",  objeto.Nacional?.CentroCustoCliente),
                    new XElement("numero_nota_fiscal",    objeto.Nacional?.NotaFiscal?.Numero),
                    new XElement("serie_nota_fiscal",     objeto.Nacional?.NotaFiscal?.Serie),
                    new XElement("valor_nota_fiscal",     objeto.Nacional?.NotaFiscal?.Valor),
                    new XElement("natureza_nota_fiscal",  objeto.Nacional?.NotaFiscal?.Natureza),
                    new XElement("descricao_objeto",      CDATA(objeto.Nacional?.DescricaoObjeto)),
                    new XElement("valor_a_cobrar",        objeto.Nacional?.ValorACobrar)
                ),

                new XElement("servico_adicional",
                    objeto.ServicosAdicionais.TiposServicos.Select(ts => new XElement("codigo_servico_adicional", ts.Codigo)),

                    new XElement("valor_declarado",  objeto.ServicosAdicionais?.ValorDeclarado),
                    new XElement("endereco_vizinho", objeto.ServicosAdicionais?.EnderecoVizinho)
                ),

                new XElement("dimensao_objeto",
                    new XElement("tipo_objeto",          objeto.Embalagem?.Codigo()),
                    new XElement("dimensao_altura",      dimensoes.Altura),
                    new XElement("dimensao_largura",     dimensoes.Largura),
                    new XElement("dimensao_comprimento", dimensoes.Comprimento),
                    new XElement("dimensao_diametro",    dimensoes.Diametro)
                )
            );
        }

        private string CDATA(string valor)
            => $"<![CDATA[{valor}]]>";
    }
}