class AFD:
  def __init__(self, states, symbols, transition_function, initial_state, final_states):
    self.states = states
    self.symbols = symbols
    self.transition_function = transition_function
    self.initial_state = initial_state
    self.final_states = final_states
    
  def read_string(self, string):
    current_state = self.initial_state
    for symbol in string:
      current_state = self.transition_function[current_state][symbol]
    return current_state in self.final_states

# Define el conjunto de estados
states = {"q1", "q2", "q3", "q4"}

# Define el conjunto de símbolos de entrada
symbols = {"a", "b"}

# Define la función de transición
transition_function = {
  "q1": {"a": "q2", "b": "q1"},
  "q2": {"a": "q3", "b": "q1"},
  "q3": {"a": "q3", "b": "q4"},
  "q4": {"a": "q4", "b": "q4"}
}

# Define el estado inicial
initial_state = "q1"

# Define los estados finales
final_states = {"q4"}

# Crea el AFD
afd = AFD(states, symbols, transition_function, initial_state, final_states)

# Prueba algunas cadenas
print(afd.read_string("aab"))  # True
print(afd.read_string("aabbb"))  # True
print(afd.read_string("abb"))  # False
