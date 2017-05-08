section .text
global _ft_isdigit

_ft_isdigit:
	cmp		rdi, 48
	jb		nope
	cmp		rdi, 57
	ja		nope
	mov		rax, 1
	ret

nope:
	mov		rax, 0
	ret