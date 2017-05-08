/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_putstrtimespace.c                               :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: hjacque <hjacque@student.42.fr>            +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2017/02/24 18:13:29 by hjacque           #+#    #+#             */
/*   Updated: 2017/03/08 14:51:01 by hjacque          ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "libft.h"

void		ft_putstrtimespace(char const *s)
{
	int	x;

	x = 0;
	while (x < 4)
		x++;
	while (x < 16)
	{
		ft_putchar(s[x]);
		x++;
	}
	ft_putchar(' ');
}
