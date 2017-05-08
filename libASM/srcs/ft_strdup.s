extern _malloc
extern _ft_strlen
extern _ft_memcpy

section .text
global _ft_strdup

_ft_strdup:
	push	r15
	push	r14
	mov		r15, rdi
	call	_ft_strlen
	mov		r14, rax
	mov		rdi, rax
	inc		rdi
	call	_malloc
	cmp		rax, 0
	je		over
	mov		[rax + r14], byte 0
	mov		rdi, rax
	mov		rsi, r15
	mov		rdx, r14
	call	_ft_memcpy

over:
	pop r14
	pop r15
	ret
