const express = require('express');
const app = express();
const morgan = require('morgan');
const conductores = require("./routes/controlVehicular/conductores");
const licencias = require("./routes/controlVehicular/licencias");
const multas = require("./routes/controlVehicular/multas");
const oficiales = require("./routes/controlVehicular/oficiales");
const propietarios = require("./routes/controlVehicular/propietarios");
const tarjetas_circulacion = require("./routes/controlVehicular/tarjetas_de_circulacion");
const vehiculos = require("./routes/controlVehicular/vehiculos");
const verificaciones = require("./routes/controlVehicular/verificaciones");

app.use(morgan('dev'));

app.get('/', (req, res) => {
    res.status(200).send("Welcomo to the DB Test");
});

app.use("/driver", conductores);
app.use("/license", licencias);
app.use("/fines", multas);
app.use("/officer", oficiales);
app.use("/owner", propietarios);
app.use("/RegisCrd", tarjetas_circulacion);
app.use("/vehicle", vehiculos);
app.use("/verifications", verificaciones);

app.listen(5000, () => {
    console.log("Server is runing . . .");
});