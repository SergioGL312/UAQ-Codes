const express = require('express');
const morgan = require('morgan');
const app = express();
const port = 5111;
const user = require('../routes/login');

app.use(morgan('dev'));

app.get('/', (req, res) => {
    res.status(200).send('Welcome to the ExpressJS change');
});

app.use('/users', user);

app.listen(process.env.PORT || port, () => {
    console.log('Server is running . . .');
});