"""A small calculator used in the VS Code training course."""

def add(a,b):
    return a+b


def total(numbers):
    result = 0
    for n in numbers:
        result = add(result, n)
    return result
