SELECT u.Nombre AS NombreUsuario,
       v.Nombre AS NombreVisitante,
       v.Dni AS DniVisitante,
       s.fecha AS FechaVisita,
       s.estado AS EstadoSolicitud
FROM solicitudes s
JOIN usuarios u ON s.id_usuario = u.id_usuario
JOIN visitantes v ON s.id_visitante = v.id_visitante;
