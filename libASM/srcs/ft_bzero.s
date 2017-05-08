section .text
global _ft_bzero

_ft_bzero:
	push		rsi
	push		rdi

while:
	cmp			esi, 0
	jle			endwhile
	mov	byte	[rdi], 0
	add			rdi, 1
	sub			esi, 1
	jmp			while

endwhile:
	pop			rdi
	pop			rsi
	ret