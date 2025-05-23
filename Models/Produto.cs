﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_Catalogo.Models;

public class Produto
{
    [Key]
    public int ProdutoId { get; set; }

    [Required(ErrorMessage = "O nome é obrigatório")]
    [StringLength(80), ]
    public string? Nome { get; set; }

    [Required(ErrorMessage = "A descrição é obrigatória")]
    [StringLength(300)]
    public string? Descricao { get; set; }

    [Required(ErrorMessage = "O preço é obrigatório")]
    [Column(TypeName = "decimal(10,2)")]
    public decimal Preco { get; set; }

    [Required(ErrorMessage = "A URL é obrigatória")]
    [StringLength(300)]
    public string? ImagemUrl { get; set; }

    public float Estoque { get; set; }
    public DateTime DataCadastro { get; set; }

    public int CategoriaId { get; set; }

    [JsonIgnore]
    public Categoria? Categoria { get; set; }
}
