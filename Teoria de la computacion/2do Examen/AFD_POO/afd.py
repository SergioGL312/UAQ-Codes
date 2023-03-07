class AFD:
    def __init__(self, estados, alfabeto, transicion, estado_inicial, estado_aceptacion):
        self.estados = estados
        self.alfabeto = alfabeto
        self.transicion = transicion
        self.estado_inicial = estado_inicial
        self.estado_aceptacion = estado_aceptacion
        self.estado_actual = None
    
    def transitar(self, estado, simbolo):
        if estado in self.estados and simbolo in self.alfabeto:
            return self.transicion[estado][simbolo]
        else:
            return None
    
    def aceptar(self, cadena):
        self.estado_actual = self.estado_inicial
        for simbolo in cadena:
            self.estado_actual = self.transitar(self.estado_actual, simbolo)
            if self.estado_actual is None:
                return False
        return self.estado_actual in self.estado_aceptacion


estados = {"q1", "q2", "q3", "q4"}
alfabeto = {"a", "b"}
transicion = {
    "q1": {"a": "q3", "b": "q2"},
    "q2": {"a": "q4", "b": "q1"},
    "q3": {"a": "q1", "b": "q4"},
    "q4": {"a": "q2", "b": "q3"}
}
estado_inicial = "q1"
estado_aceptacion = {"q1"}

afd = AFD(estados, alfabeto, transicion, estado_inicial, estado_aceptacion)

cadena = "aaaabb"
if afd.aceptar(cadena):
    print("La cadena", cadena, "es aceptada por el autómata.")
else:
    print("La cadena", cadena, "no es aceptada por el autómata.")
