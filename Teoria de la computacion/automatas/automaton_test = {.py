automaton_test = {
	"states": {"X", "Y", "Z"}, 
	"symbols": {"B", "A"}, 
	"initial_state": "X", 
	"final_states": {"Z"}, 
	"transitions": {
		"Z":{"B": "Z", "A": "Z"}, 
		"Y":{"B": "Z", "A": "X"}, 
		"X":{"B": "Z", "A": "Y"}
	}
}

def check_expression(automaton, expression: str) -> bool:
    state = automaton.get('initial_state')
    for item in expression.upper():
        if item not in automaton.get('symbols'):
            return False
        transition = automaton.get('transitions').get(state)
        state = transition.get(item)
    return state in automaton.get('final_states')


string = input('Ingrese la cadena >> ')
print(check_expression(automaton_test, string))