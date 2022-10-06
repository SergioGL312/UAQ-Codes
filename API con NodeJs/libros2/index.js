const express = require('express');
const app = express();
const morgan = require('morgan');
const libros2 = require('../routes/libros2');
const PORT = 5111; 

app.use(morgan('dev'));

app.get('/', (req, res) => {
    res.status(200).send('Welcome to the API libros2');
});

app.use('/libros', libros2);

app.listen(PORT, () => {
   console.log('Server is running . . .'); 
});