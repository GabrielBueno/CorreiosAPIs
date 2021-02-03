using System;
using System.Collections.Generic;
using System.Linq;
using CorreiosAPI.SIGEP.Data;
using CorreiosAPI.SIGEP.Exception;
using CorreiosAPI.SIGEP.Interfaces;

namespace CorreiosAPI.SIGEP.Validadores {
    public class ValidadorRequest : IValidador {
        public void Validar(FechamentoPLP fechamento) {
            Obrigatorio(fechamento.ObjetosPostais,   "O fechamento da pré-lista de postagem deve conter ao menos um objeto postal");
            Obrigatorio(fechamento.PreListaPostagem, "O fechamento da PLP deve conter uma pŕe-lista de postagem");
            Obrigatorio(fechamento.Remetente,        "Os dados do remetente devem ser informados no fechamento da PLP");

            Validar(fechamento.PreListaPostagem);
            Validar(fechamento.Remetente);
            Validar(fechamento.ObjetosPostais);
        }

        public void Validar(PreListaPostagem plp) {
            Obrigatorio(plp.CartaoPostagem, "O cartão de postagem deve ser informado na PLP");
        }

        public void Validar(Remetente remetente) {
            Obrigatorio(remetente.Nome,                 "O nome do remetente é obrigatório");
            Obrigatorio(remetente.NumeroContrato,       "O número de contrato do remetente é obrigatório");
            Obrigatorio(remetente.NumeroDiretoria,      "O número da diretoria regional do contrato do remetente é obrigatório");
            Obrigatorio(remetente.CodigoAdministrativo, "O código administrativo do contrato do remetente é obrigatório");
            
            Obrigatorio(remetente.Endereco,            "O endereço do remetente é obrigatório");
            Obrigatorio(remetente.Endereco.Logradouro, "O logradouro do remetente é obrigatório");
            Obrigatorio(remetente.Endereco.Numero,     "O número do endereço do remetente é obrigatório");
            Obrigatorio(remetente.Endereco.Bairro,     "O bairro do remetente é obrigatório");
            Obrigatorio(remetente.Endereco.Cep,        "O CEP do remetente é obrigatório");
            Obrigatorio(remetente.Endereco.Cidade,     "A cidade do remetente é obrigatório");
            Obrigatorio(remetente.Endereco.Uf,         "A UF do endereço do remetente é obrigatória");

            Verdade(remetente.CienciaConteudoProibido, "O remetente deve estar ciente de que do risco da postagem de objetos proibidos");
        }

        public void Validar(ObjetoPostal objeto) {
            Obrigatorio(objeto.PesoGramas, "O peso do objeto postal é obrigatório");

            Obrigatorio(objeto.Etiqueta,        "A etiqueta do objeto postal é obrigatória");
            Obrigatorio(objeto.ServicoPostagem, "O serviço de postagem do objeto postal é obrigatório");
            Obrigatorio(objeto.Embalagem,       "Os dados da embalagem do objeto postal são obrigatórios");

            Obrigatorio(objeto.Destinatario,                     "Os dados do destinatário do objeto postal são obrigatórios");
            Obrigatorio(objeto.Destinatario.Nome,                "O nome do destinatário é obrigatório");
            Obrigatorio(objeto.Destinatario.Endereco,            "O endereço do remetente é obrigatório");
            Obrigatorio(objeto.Destinatario.Endereco.Logradouro, "O logradouro do remetente é obrigatório");
            Obrigatorio(objeto.Destinatario.Endereco.Numero,     "O número do endereço do remetente é obrigatório");
            Obrigatorio(objeto.Destinatario.Endereco.Bairro,     "O bairro do remetente é obrigatório");
            Obrigatorio(objeto.Destinatario.Endereco.Cep,        "O CEP do remetente é obrigatório");
            Obrigatorio(objeto.Destinatario.Endereco.Cidade,     "A cidade do remetente é obrigatório");
            Obrigatorio(objeto.Destinatario.Endereco.Uf,         "A UF do endereço do remetente é obrigatória");

            Verdade(objeto.CienciaConteudoProibido, "O remetente deve declarar ciência de que o objeto postal não se enquadra como proibido ou restrito");
        }

        public void Validar(List<ObjetoPostal> objetos)
            => objetos.ForEach(o => Validar(o));

        /* -- ----- Utils ----- -- */

        private void Obrigatorio(string valor, string msg) {
            if (valor == null || valor.Trim() == "")
                throw new SIGEPValidacaoException(msg);
        }

        private void Obrigatorio<T>(List<T> lista, string msg) {
            if (lista == null || lista.Count == 0)
                throw new SIGEPValidacaoException(msg);
        }

        private void Obrigatorio(object valor, string msg) {
            if (valor == null)
                throw new SIGEPValidacaoException(msg);
        }

        private void Existe<T>(T algum, List<T> em, string msg) where T : IEq  {
            if (em == null || !em.Any(v => v.Eq(algum)))
                throw new SIGEPValidacaoException(msg);
        }

        private void Verdade(bool afirmacao, string msg) {
            if (!afirmacao)
                throw new SIGEPValidacaoException(msg);
        }
    }
}