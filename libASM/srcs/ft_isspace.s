section .text
global _ft_isspace

_ft_isspace:
	cmp		rdi, 9
	je		over
	cmp		rdi, 10
	je		over
	cmp		rdi, 11
	je		over
	cmp		rdi, 12
	je		over
	cmp		rdi, 13
	je		over
	cmp		rdi, 32
	je		over
	xor		rax, rax
	ret

over:
	mov		rax, 1
	ret
