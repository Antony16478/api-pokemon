📝 Informe de la Tarea – Consumo de API con Windows Forms en C#
# *¿Qué API usaste?*
Para esta tarea decidí trabajar con la PokeAPI, una API pública que permite consultar información de los Pokémon, como su nombre, altura, peso, tipos y hasta su imagen oficial. Lo bueno de esta API es que no requiere autenticación ni llaves especiales, lo cual facilita mucho las pruebas.

¿Qué dificultades encontraste y cómo las resolviste?
Una de las cosas que más me costó fue entender cómo venía la información en el JSON. Algunas partes venían dentro de listas o anidadas en otras secciones, como los tipos de Pokémon, y eso me confundía al principio. Para resolverlo, creé clases específicas en C# que reflejaran esa estructura, ayudándome de ejemplos que encontré y ajustándolos según lo que necesitaba.

Otro detalle fue que, cuando hacía la petición a la API, la interfaz se congelaba por unos segundos. Me di cuenta de que eso pasaba porque la llamada no era asíncrona. Después de investigar, usé async y await para que el programa no se trabara mientras esperaba la respuesta.

También me tomó algo de tiempo aprender cómo cargar la imagen del Pokémon directamente desde internet en un PictureBox, pero al final logré mostrarla usando PictureBox.Load() con la URL que venía en los datos de la API.

¿Qué aprendiste con esta tarea?
Aprendí a consumir una API REST desde una aplicación Windows Forms, y a trabajar con peticiones HTTP usando HttpClient. También entendí cómo deserializar datos JSON en objetos de C#, cómo mostrar esa información en pantalla y cómo manejar errores si el usuario escribe mal el nombre de un Pokémon o si la API no responde.

Además, implementé una opción para guardar los resultados en un archivo .txt, algo que no había hecho antes con C#, y me pareció útil para tener un pequeño historial de búsquedas.

¿Cómo te apoyaste de la IA para resolver tus dudas?
Durante el desarrollo me apoyé bastante en la IA para resolver dudas específicas y avanzar más rápido. Por ejemplo, me ayudó a:

Generar el código base dividido en archivos.

Crear las clases correctas para leer bien el JSON de la API.

Entender cómo aplicar async y await en eventos de botones.

Solucionar errores al cargar imágenes o mostrar los datos.

No copié todo literalmente, pero sí tomé ejemplos y los adapté a lo que yo quería. Fue como tener a alguien al lado explicándome y dándome ejemplos listos para probar.
