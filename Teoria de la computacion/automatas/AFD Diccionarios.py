states = ["q0", "q1", "q2"]  # conjunto de estados
alphabet = ["a", "b"]  # alfabeto de entrada

# función de transición
transition_function = {
    ("q0", "a"): ["q0", "q1"],
    ("q0", "b"): ["q0"],
    ("q1", "a"): ["q1"],
    ("q1", "b"): ["q2"],
    ("q2", "a"): ["q2"],
    ("q2", "b"): ["q2"],
}

initial_state = "q0"  # estado inicial
final_states = ["q2"]  # conjunto de estados finales

def is_accepted(string):
    # lista de estados a los que se puede llegar
    current_states = transition_function[(initial_state, string[0])]
    for letter in string[1:]:
        next_states = []
        for state in current_states:
            next_states += transition_function[(state, letter)]
        current_states = next_states
    # determina si alguno de los estados actuales es un estado final
    return any(state in final_states for state in current_states)

# pruebas
print(is_accepted("abb"))  # True
print(is_accepted("ababb"))  # True
print(is_accepted("a"))