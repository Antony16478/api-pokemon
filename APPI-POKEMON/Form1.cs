using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PokeApiWinForms
{
    public partial class Form1 : Form
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtPokemon.Text.Trim().ToLower();
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Ingresa un nombre de Pokémon.");
                return;
            }

            try
            {
                string url = $"https://pokeapi.co/api/v2/pokemon/{nombre}";
                var response = await _httpClient.GetAsync(url);

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("No se encontró el Pokémon.");
                    return;
                }

                var content = await response.Content.ReadAsStringAsync();
                var pokemon = JsonSerializer.Deserialize<PokemonData>(content);

                MostrarDatos(pokemon);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el Pokémon: " + ex.Message);
            }
        }

        private void MostrarDatos(PokemonData pokemon)
        {
            lblNombre.Text = $"Nombre: {pokemon.Name}";
            lblAltura.Text = $"Altura: {pokemon.Height}";
            lblPeso.Text = $"Peso: {pokemon.Weight}";
            lblTipos.Text = "Tipos: " + string.Join(", ", pokemon.Types.ConvertAll(t => t.Type.Name));
            picPokemon.Load(pokemon.Sprites.FrontDefault);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPokemon.Clear();
            lblNombre.Text = "";
            lblAltura.Text = "";
            lblPeso.Text = "";
            lblTipos.Text = "";
            picPokemon.Image = null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtPokemon.Text.Trim();
            if (string.IsNullOrEmpty(nombre)) return;

            var datos = $"{lblNombre.Text}\n{lblAltura.Text}\n{lblPeso.Text}\n{lblTipos.Text}";

            File.WriteAllText($"{nombre}_info.txt", datos);
            MessageBox.Show("Datos guardados correctamente.");
        }

        private void picPokemon_Click(object sender, EventArgs e)
        {

        }
    }
}
