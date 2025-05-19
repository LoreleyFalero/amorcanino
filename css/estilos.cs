* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}

html, body {
  max-width: 100%;
  overflow-x: hidden;
  height: 100%;
  margin: 0;
  padding: 0;
}

body {
  display: flex;
  flex-direction: column;
  min-height: 100vh;
}

main {
  flex-grow: 1;
}

body {
  background-color: #d4d4d4 !important;
  font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
  min-height: 100vh;
  width: 100%;
}

nav {
  display: flex;
  flex-direction: row;
  justify-content: space-between;
  align-items: center;
  gap: 1.25rem;
  background-color: #FFACF0 !important;
  font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
  text-align: center;
  text-transform: uppercase;
  letter-spacing: 5px;
  word-spacing: 90px;
  font-size: 20px;
  width: 100%;
  padding: 15px 20px;
}
nav .logo img {
  display: block;
  height: 100px;
}
nav .menu {
  display: flex;
  flex-direction: row;
  justify-content: center;
  align-items: center;
  gap: 5rem;
  flex-grow: 1;
  width: 100%;
}
nav .menu a {
  color: black;
  text-decoration: none;
  font-size: 25px;
  font-weight: bold;
  text-transform: uppercase;
}

.tituloprincipalinicio {
  font-family: Verdana, Geneva, Tahoma, sans-serif;
  font-weight: 900;
  text-align: center;
  margin-bottom: 70px;
  padding: 15px;
  font-size: 2.1875rem;
  color: black;
  font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
  font-weight: 900;
  white-space: nowrap;
}
.tituloprincipalinicio h1 {
  opacity: 0;
  transform: translateY(-20px);
  animation: fadeInUp 1.5s ease-out forwards;
}

@keyframes fadeInUp {
  to {
    opacity: 1;
    transform: translateY(0);
  }
}
.titulosecundario {
  color: black;
  font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
  font-size: 30px;
  display: inline-block;
  width: 43%;
  text-align: right;
  margin-top: 10px;
}

li {
  color: white;
  text-decoration: underline;
}

.fondorosa {
  width: 55%;
  padding: 40px;
  margin: 50px;
  text-align: left;
  background: #B14890;
  font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
  white-space: nowrap;
  font-size: 30px;
  border-radius: 20px;
  box-shadow: 0 0 15px rgba(0, 0, 0, 0.2);
}

footer {
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  width: 100%;
  margin-top: 3rem;
  padding: 1.5rem 0;
  text-align: center;
  font-size: 1rem;
  font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
  color: black;
}
footer p {
  font-size: 0.875rem;
  color: black;
  margin-top: 0.5rem;
}

.imageninicio {
  position: absolute;
  bottom: 140px;
  left: 1260px;
  overflow: hidden;
  display: inline-block;
}
.imageninicio img {
  transition: transform 0.5s ease-in-out;
  display: block;
  width: 100%;
  height: auto;
}
.imageninicio:hover img {
  transform: scale(1.1);
}

p {
  color: black;
  font-family: Arial, Helvetica, sans-serif;
  font-size: 1.125rem;
  width: 45%;
  padding: 20px;
  margin: 0;
}

.contenedor-flex {
  display: flex;
  gap: 2rem;
  align-items: stretch;
  justify-content: space-between;
  padding: 2rem;
  flex-direction: row;
  background-color: transparent;
  width: 90%;
  max-width: 1200px;
  margin: 0 auto;
  margin-left: 0%;
}
.contenedor-flex .fondorosa {
  background-color: #B14890;
  padding: 2rem;
  border-radius: 1rem;
  width: 90%;
  color: black;
  text-align: left;
  box-sizing: border-box;
}
.contenedor-flex .fondorosa ul {
  padding: 0;
  margin: 0;
}
.contenedor-flex .fondorosa ul li {
  list-style: disc inside;
  font-weight: bold;
  margin-bottom: 0.5rem;
}
.contenedor-flex .fondorosa p {
  margin-bottom: 1rem;
  font-size: 1.125rem;
  color: black;
}
.contenedor-flex .imageninicio {
  width: 50%;
  max-width: 100%;
  overflow: hidden;
}
.contenedor-flex .imageninicio picture {
  display: block;
}
.contenedor-flex .imageninicio picture img {
  width: 50%;
  height: auto;
  object-fit: cover;
  border-radius: 1rem;
  display: block;
}

nav {
  display: flex;
  font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
  text-align: center;
  align-items: center;
  justify-content: space-between;
  text-transform: uppercase;
  letter-spacing: 5px;
  word-spacing: 90px;
  text-decoration: none;
  font-size: 20px;
  width: 100%;
  padding: 15px 20px;
  background: #B14890;
}
nav .logo img {
  display: block;
  height: 100px;
}
nav .menu {
  display: flex;
  justify-content: center;
  flex-grow: 1;
  gap: 80px;
  width: 100%;
}
nav .menu a {
  color: black;
  text-decoration: none;
  font-size: 25px;
  font-weight: bold;
  text-transform: uppercase;
}

.tituloprincipalinicioservicios {
  color: black;
  font-size: 2.1875rem;
  font-family: Verdana, Geneva, Tahoma, sans-serif;
  font-weight: 900;
  white-space: nowrap;
  text-align: center;
  margin-bottom: 70px;
  padding: 15px;
}

.titulosecundarioservicios {
  color: rgb(0, 0, 0);
  font-size: 1.5rem;
  font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
  display: inline-block;
  width: 100%;
  text-align: center;
}

.contenedor {
  display: grid;
  grid-template-columns: repeat(2, 1fr);
  gap: 20px;
  margin-top: 50px;
  text-align: center;
}

.columna {
  display: flex;
  flex-direction: column;
  align-items: center;
}

.serviciobasico,
.serviciocompleto {
  color: #000000;
  font-family: Arial, Helvetica, sans-serif;
  font-size: 1.125rem;
  font-weight: 600;
  margin-bottom: 25px;
}

.lista {
  padding: 60px;
  font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
  background-color: #B14890;
  border-radius: 10px;
  width: 500px;
  text-align: center;
  box-shadow: 0 8px 24px rgba(0, 0, 0, 0.4);
}

.lista li {
  color: black;
  font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
  font-size: 1.125rem;
  padding: 6px 0;
  text-decoration: none;
}

.galeria h1 {
  font-family: Verdana, Geneva, Tahoma, sans-serif;
  font-weight: 900;
  text-align: center;
  margin-bottom: 70px;
  padding: 15px;
  font-size: 2.1875rem;
  color: black;
  font-size: 2.1875rem;
  margin-top: 4rem;
  font-family: Verdana, Geneva, Tahoma, sans-serif;
  font-weight: 900;
  text-align: center;
  margin-bottom: 4.375rem;
  padding: 0.9375rem;
}
.galeria #carouselExampleIndicators {
  max-width: 400px !important;
  margin: 2rem auto;
}
.galeria #carouselExampleIndicators .carousel-item img {
  height: 250px !important;
  object-fit: cover;
  border-radius: 0.625rem;
  width: 100% !important;
}
.galeria #carouselExampleIndicators .carousel-control-prev-icon,
.galeria #carouselExampleIndicators .carousel-control-next-icon {
  background-color: rgba(0, 0, 0, 0.5);
  border-radius: 50%;
  padding: 1.25rem;
}
.galeria #carouselExampleIndicators .carousel-indicators button {
  background-color: gray;
  width: 0.75rem;
  height: 0.75rem;
  border-radius: 50%;
  opacity: 0.5;
}
.galeria #carouselExampleIndicators .carousel-indicators .active {
  background-color: white;
  opacity: 1;
}

@media (max-width: 768px) {
  #carouselExampleIndicators {
    max-width: 100% !important;
  }
  #carouselExampleIndicators .carousel-item img {
    height: 150px !important;
  }
}
section {
  background-color: #B14890;
  padding: 30px;
  border-radius: 15px;
  max-width: 900px;
  margin: 40px auto;
  display: flex;
  flex-direction: column;
  align-items: center;
  gap: 25px;
}
section h1 {
  font-weight: 900;
  text-align: center;
  font-size: 2.5rem;
}
section .informacion {
  width: 100%;
  max-width: 600px;
  text-align: center;
  margin-bottom: 10px;
}
section .informacion .detalle {
  margin-bottom: 10px;
}
section .informacion .detalle .titulo {
  font-weight: bold;
  font-size: 1.125rem;
  margin-bottom: 5px;
}
section .mapa {
  width: 100%;
  max-width: 700px;
}
section .mapa iframe {
  width: 100% !important;
  height: 400px !important;
  border: none;
  border-radius: 10px;
}
section a.btn.btn-success {
  padding: 12px 30px;
  font-size: 1.125rem;
  border-radius: 10px;
  max-width: 200px;
  width: 100%;
  text-align: center;
  transition: background-color 0.3s ease;
}
section a.btn.btn-success:hover {
  background-color: rgb(17.03125, 91.96875, 57.225);
}
section .instagram-container {
  width: 100%;
  max-width: 600px;
  display: flex;
  justify-content: center;
  margin-top: 15px;
}
section .instagram-container .instagram-box {
  display: flex;
  align-items: center;
  gap: 10px;
}
section .instagram-container .instagram-box .logo-instagram {
  width: 40px;
}
section .teesperamos {
  font-size: 1rem;
  margin-top: 20px;
}

.informacion {
  margin: 20px 0;
  padding: 10px;
}

.mapa {
  height: 15.625rem;
  margin: 15px 0;
}

a.btn.btn-success {
  max-width: 100%;
  font-size: 1rem;
}

.instagram-container {
  flex-direction: column;
}
.instagram-container .instagram-box {
  flex-direction: column;
  gap: 8px;
}
.instagram-container .instagram-box .logo-instagram {
  width: 35px;
}

.teesperamos {
  font-size: 0.875rem;
}

.reservesuturno {
  color: black;
  font-size: 1.75rem;
  font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
  font-weight: 900;
  white-space: nowrap;
  text-align: center;
  margin-bottom: 4.375rem;
  padding: 0.9375rem;
}

form {
  background-color: #B14890;
  padding: 1.875rem;
  max-width: 800px;
  margin: auto;
  box-shadow: 0 0 35px rgba(0, 0, 0, 0.4);
  border-radius: 8px;
}

.forminput {
  padding: 6px 20px;
}

input, textarea {
  width: 100%;
  box-sizing: border-box;
  padding: 6px;
  border: none;
  border-left: 3px solid #B14890;
}

textarea {
  min-width: 100%;
  resize: vertical;
  min-height: 100px;
  max-height: 200px;
  font-family: sans-serif;
}

form h2 {
  color: black;
  text-align: center;
  margin: 0 0 8px 0;
  font-size: 1.5625rem;
  font-family: Verdana, Geneva, Tahoma, sans-serif;
}

label {
  font-size: 1rem;
  line-height: 2;
  text-transform: uppercase;
  font-family: Arial, Helvetica, sans-serif;
}

a {
  color: black;
  text-decoration: none;
}
a:hover {
  text-decoration: underline;
}

iframe {
  display: block;
  margin: 20px auto;
  border: none;
  max-width: 100%;
  height: 18.75rem;
}

html, body {
  max-width: 100%;
  overflow-x: hidden;
}

body {
  font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
  margin: 0;
  padding: 0;
  background-color: #d4d4d4;
  color: black;
}

.header {
  background-color: #B14890;
  color: white;
  padding: 1rem;
  text-align: center;
}
.header .menu {
  display: flex;
  flex-direction: column;
  gap: 0.5rem;
}
.header .menu a {
  color: white;
  text-decoration: none;
  font-weight: bold;
}
.header .menu a:hover {
  text-decoration: underline;
}

.main {
  padding: 1rem;
  text-align: center;
}

.presentacion,
.servicios-destacados,
.galeria {
  margin-bottom: 2rem;
}

.servicios-destacados__lista {
  list-style: none;
  padding: 0;
}
.servicios-destacados__lista li {
  margin-bottom: 0.5rem;
}

.galeria__imagenes {
  display: grid;
  grid-template-columns: 1fr;
  gap: 1rem;
}
.galeria__imagenes img {
  width: 100%;
  border-radius: 10px;
}

.footer {
  background-color: #B14890;
  color: white;
  text-align: center;
  padding: 1rem;
}

@media (min-width: 768px) {
  .header .menu {
    flex-direction: row;
    justify-content: center;
    gap: 1rem;
  }
  .galeria__imagenes {
    grid-template-columns: repeat(2, 1fr);
  }
}
@media (min-width: 1024px) {
  .main {
    padding: 2rem 4rem;
  }
  .presentacion,
  .servicios-destacados,
  .galeria {
    max-width: 1200px;
    margin: 0 auto 3rem auto;
    text-align: left;
  }
  .galeria__imagenes {
    grid-template-columns: repeat(3, 1fr);
  }
  .header .menu {
    justify-content: flex-end;
    padding-top: 1rem;
  }
  .header__contenido {
    display: flex;
    justify-content: space-between;
    align-items: center;
    flex-wrap: wrap;
  }
}
* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}

html, body {
  max-width: 100%;
  overflow-x: hidden;
}

body {
  background-color: #d4d4d4;
  font-family: Arial, Helvetica, sans-serif;
  min-height: 100vh;
  width: 100%;
}

.amorcanino-titulo-principal {
  font-family: Verdana, Geneva, Tahoma, sans-serif;
  font-weight: 900;
  text-align: center;
  margin-bottom: 70px;
  padding: 15px;
  font-size: 1.75rem;
  color: black;
  font-size: 2rem;
  font-family: Verdana, Geneva, Tahoma, sans-serif;
  white-space: normal;
  animation: fadeInUp 1.5s ease-out forwards;
  opacity: 0;
  transform: translateY(-20px);
}

.amorcanino-titulo-secundario {
  color: black;
  font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
  font-size: 1.75rem;
  display: block;
  width: 100%;
  text-align: center;
  margin-top: 10px;
}

.fondorosa {
  background: #B14890;
  font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
  font-size: 1.125rem;
  padding: 2.5rem;
  margin: 3rem auto 1rem;
  max-width: 100%;
  border-radius: 1.25rem;
  box-shadow: 0 8px 24px rgba(0, 0, 0, 0.4);
}

p {
  color: black;
  font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
  font-size: 1.125rem;
  width: 100%;
  padding: 0.625rem;
  margin: 0 auto;
}

.wrapper, .main-container {
  display: flex;
  flex-direction: column;
  min-height: 100vh;
}

main {
  flex: 1;
}

/*# sourceMappingURL=estilos.cs.map */
