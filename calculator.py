"""A small calculator for the VS Code course."""

def add(a,b):
    return a+b


def total(numbers):
    result = 0
    for n in numbers:
        result = add(result, n)
    return result
