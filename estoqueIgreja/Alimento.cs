using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estoqueIgreja
{
    internal class Alimento
    {
        private int _codigo;
        private DateTime _insercao;
        private DateTime _vencimento;
        private _Enum.Estado _estado;
        private _Enum.Categoria _categoria;
        private string _nome;
        private string _peso;
        

       public Alimento()
        {
            
        }

        public int GetCodigo()
        {
            return _codigo;
        }

        public void SetCodigo()
        {

            Conexao c = new Conexao();
           
            _codigo = c.GerarCodigoProduto();
        }

        public bool SetCodigo(int codigo)
        {
            if (codigo <= 0 || _codigo != -1)
            {
                _codigo = codigo;
                return true;
            }
            return false;
        }

        public DateTime GetInsercao()
        {
            return _insercao.Date;
        }

        public void SetInsercao()
        {
            _insercao = DateTime.Now.Date;
        }
        public void SetInsercao(DateTime t)
        {
            _insercao = t.Date;
        }

        public DateTime GetVencimento()
        {
            return _vencimento.Date;
        }

        public bool SetVenciMento(DateTime dataVencimento, bool dataValidade)
        {
            if (dataVencimento.Date <= DateTime.Now.Date && dataValidade)
            {
                
                DialogResult resultado = MessageBox.Show(
                "Esse item já passou da data de validade, deseja continuar?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
);

                if (resultado == DialogResult.Yes)
                {
                    _vencimento = dataVencimento.Date;
                    this.SetEstado();
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                _vencimento = dataVencimento.Date;
                this.SetEstado();
                return true;
            }
        }

        public void SetVenciMentoSemValidacao(DateTime dataVencimento)
        {
            _vencimento = dataVencimento.Date;
            this.SetEstado();
        }

        public _Enum.Estado GetEstado()
        {
            SetEstado();
            return _estado;
        }

        private void SetEstado()
        {
            _estado = _vencimento switch
            {
                var d when d.Date <= DateTime.Now.Date
                    => _Enum.Estado.VENCIDO,

                var d when d.Year == DateTime.Now.Year && d.Month == DateTime.Now.Month
                    => _Enum.Estado.PERTO_DO_VENCIMENTO,

                _ => _Enum.Estado.LONGE_DO_VENCIMENTO
            };
        }
       
        public _Enum.Categoria GetCategoria()
        {
            return _categoria;
        }

        public void SetCategoria(_Enum.Categoria categoria)
        {
            if(categoria != null)
            {
                _categoria = categoria;
            }
            else
            {
                MessageBox.Show("Selecione a categoria corretamente", "Informação Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public string GetNome()
        {
            return _nome;
        }

        public bool SetNome(string nome)
        {
            if (nome.Count() > 100)
            {
                MessageBox.Show("O nome deve conter menos que 100 caracteres", "Informação Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!string.IsNullOrEmpty(nome))
            {
                _nome = nome;
                return true;
            }
            else
            {
                MessageBox.Show("Selecione o nome corretamente", "Informação Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void SetPeso(string peso)
        {
            _peso = peso;
        }

        public string GetPeso()
        {
            return _peso;
        }
    }
}
