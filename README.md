# YOUTUBE-CSharpForm-01DotNetFramework

# Atajos y Tips
* ```c#
    //  //Metodo donde se inicializan todos los componentes del formulario 
    //  //  y se especifican sus configuraciones iniciales.
    InitializeComponent();
    ```

* Ver las propiedades 
    - Tecla F4
    - Teniendo seleccionado una propiedad, si presionamos F4 podemos rapidamente modificar el valor o sus valores de la propiedad
* Si seleccionamos un elemento y presionamos **"enter"**, nos lleva a agregarle codigo en su evento OnClick.
* Si Selecciono un elemento y
    - Presiono Ctrl + Flechas(arriba, abajo, derecha, izquierda) : Me mueve el elemento
    - Presiono Shift + Flechas(arriba, abajo, derecha, izquierda) : Me cambia las dimensiones de alto y ancho en cantidades pequeñas
    - Presiono Ctrl + Shift + Flechas(abajo, derecha) : Me cambia las dimensiones de alto y ancho en cantidades grandes
    - Ctrl + Click Derecho y muevo el cursor, **estare creando** un nuevo elemento del mismo tipo sin tener que ir al toolbox
* Si quiero agregar varios elementos del mismo tipo, entonces seleccion el elemento y 
    presion CTRL y empiezo uno por uno a la ves
* Si seleccion un elemento de Toolbox, y si doy "enter" entonces automaticamente me los agrega al Form en una esquina del Form
* Si estoy en el Toolbox y presiono la Tecla "L", hara que se valla a la palabla que empieza con la L, tal como label.
* Mostrar las herramientas
    - Ver -> Toolbox o 	Ctrl+Alt+X
* Ctrl + Shift + S: Guardar todos los archivos abiertos.
* F7: Cambiar entre la vista de diseño y el código subyacente del formulario.
* Shift + F7: Cambiar entre la vista de codigo y el Diseño.
* Tab: Seleccionar un elemento del formulario o Desplazarse a la siguiente.
* F4: Abrir la ventana Propiedades para el elemento seleccionado.
* F5: Correr el programa
* Ctrl + .: Mostrar la lista de sugerencias y correcciones rápidas.
* Ctrl + T: Buscar tipos, métodos y símbolos en el proyecto.
* Ctrl + M, Ctrl + M: Plegar o desplegar el bloque de código actual.
* En el diseñador **Ctrl + Shift + F10**: Abrir el menú contextual del control seleccionado para acceder a sus propiedades.
* Por default el label se agrega con una propiedad autosize en true, y es por eso que el label no tiene los puntos para pode hacerlo mas grande o mas pequeño, si quisieramos hacerlo mas grande o pequeño tendriamos que ponerle en autosize en false

# Cursos 
* https://www.youtube.com/playlist?list=PLAzlSdU-KYwVRRO6P9fn1LcoXSITIIev0
* https://www.youtube.com/watch?v=p_kafMb3ygM
* https://www.youtube.com/watch?v=AN79L5B7a58&list=PLM-p96nOrGcZezSAPW08ulofVcEZRpYfH&index=2

# Codigo clases y metodos.
* Nombre de la **variable** que identifica al elemento 
    - .Name = "button1";
* **Posicion** del elemento
    - .Location = new System.Drawing.Point(12, 111);
* Ponerle **texto** visual al elemento
    - .Text = "Boton que cambia texto\r\n";
* Definir tamaños de **dimension**
    - .Size = new System.Drawing.Size(161, 23);
* **Habilitar o desabilitar** el elemento
    - .Enabled = true;
* Hacer **visible** o no el elemento
    - .Visible = true;
* Ponerle fuente a un elemento
    ```C#
    new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    ```
* Registrar un manejado de eventos
    - ```c#
        // registra un manejador de eventos para el evento Click
        miBoton.Click += new EventHandler(miBoton_Click);

        // definición del manejador de eventos
        void miBoton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Botón clickeado");
        }

        // simula un clic en el botón
        miBoton.PerformClick();
    ```
* ```c#
    // añade texto al final de la caja de texto
    miCajaDeTexto.AppendText("\nTexto añadido");

    // borra el texto de la caja de texto
    miCajaDeTexto.Clear();
    ```