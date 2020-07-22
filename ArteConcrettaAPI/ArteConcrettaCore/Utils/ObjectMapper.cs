using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ArteConcrettaCore.Utils
{
	public static class ObjectMapper
	{
		public static T Converter<T>(this object objetoOrigem)
		{
			PropertyInfo[] propriedadesOrigem = objetoOrigem.GetType().GetProperties();
			PropertyInfo[] propriedadesDestino = typeof(T).GetProperties();
			var objetoDestino = Activator.CreateInstance(typeof(T));
			foreach (var property in propriedadesOrigem)
				if (propriedadesDestino.Any(t => (t.Name.Equals(property.Name)) && t.PropertyType == property.PropertyType))
				{
					var propriedade = objetoDestino.GetType().GetProperty(property.Name);
					var valor = objetoOrigem.GetType().GetProperty(property.Name).GetValue(objetoOrigem, null);
					propriedade.SetValue(objetoDestino, valor);
				}

			return (T)objetoDestino;
		}

		public static IEnumerable<T> ConverterList<T>(this object list)
		{
			if (!(list is IEnumerable))
				throw new InvalidOperationException("Operação inválida");

			foreach (var item in (IEnumerable)list)
				yield return item.Converter<T>();
		}
	}
}
