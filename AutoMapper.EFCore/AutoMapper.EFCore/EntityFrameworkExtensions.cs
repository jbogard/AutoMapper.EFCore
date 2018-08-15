namespace AutoMapper.EFCore
{
    using System;
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;
    using QueryableExtensions;

    public static class EntityFrameworkExtensions
    {
        public static Task<List<TDestination>> ProjectToListAsync<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return queryable.ProjectTo<TDestination>(config).ToListAsync();
        }

        public static Task<List<TDestination>> ProjectToListAsync<TDestination>(this IQueryable queryable)
        {
            return queryable.ProjectTo<TDestination>().ToListAsync();
        }

        public static Task<TDestination[]> ProjectToArrayAsync<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return queryable.ProjectTo<TDestination>(config).ToArrayAsync();
        }

        public static Task<TDestination[]> ProjectToArrayAsync<TDestination>(this IQueryable queryable)
        {
            return queryable.ProjectTo<TDestination>().ToArrayAsync();
        }

        public static Task<TDestination> ProjectToSingleOrDefaultAsync<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return queryable.ProjectTo<TDestination>(config).SingleOrDefaultAsync();
        }

        public static Task<TDestination> ProjectToSingleOrDefaultAsync<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate, IConfigurationProvider config)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>(config).SingleOrDefaultAsync();
        }

        public static Task<TDestination> ProjectToSingleOrDefaultAsync<TDestination>(this IQueryable queryable)
        {
            return queryable.ProjectTo<TDestination>().SingleOrDefaultAsync();
        }

        public static Task<TDestination> ProjectToSingleOrDefaultAsync<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>().SingleOrDefaultAsync();
        }

        public static Task<TDestination> ProjectToSingleAsync<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return queryable.ProjectTo<TDestination>(config).SingleAsync();
        }

        public static Task<TDestination> ProjectToSingleAsync<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate, IConfigurationProvider config)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>(config).SingleAsync();
        }

        public static Task<TDestination> ProjectToSingleAsync<TDestination>(this IQueryable queryable)
        {
            return queryable.ProjectTo<TDestination>().SingleAsync();
        }

        public static Task<TDestination> ProjectToSingleAsync<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>().SingleAsync();
        }

        public static Task<TDestination> ProjectToFirstOrDefaultAsync<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return queryable.ProjectTo<TDestination>(config).FirstOrDefaultAsync();
        }

        public static Task<TDestination> ProjectToFirstOrDefaultAsync<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate, IConfigurationProvider config)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>(config).FirstOrDefaultAsync();
        }

        public static Task<TDestination> ProjectToFirstOrDefaultAsync<TDestination>(this IQueryable queryable)
        {
            return queryable.ProjectTo<TDestination>().FirstOrDefaultAsync();
        }

        public static Task<TDestination> ProjectToFirstOrDefaultAsync<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>().FirstOrDefaultAsync();
        }

        public static Task<TDestination> ProjectToFirstAsync<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return queryable.ProjectTo<TDestination>(config).FirstAsync();
        }

        public static Task<TDestination> ProjectToFirstAsync<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate, IConfigurationProvider config)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>(config).FirstAsync();
        }

        public static Task<TDestination> ProjectToFirstAsync<TDestination>(this IQueryable queryable)
        {
            return queryable.ProjectTo<TDestination>().FirstAsync();
        }

        public static Task<TDestination> ProjectToFirstAsync<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>().FirstAsync();
        }

        public static List<TDestination> ProjectToList<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return queryable.ProjectTo<TDestination>(config).ToList();
        }

        public static List<TDestination> ProjectToList<TDestination>(this IQueryable queryable)
        {
            return queryable.ProjectTo<TDestination>().ToList();
        }

        public static TDestination[] ProjectToArray<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return queryable.ProjectTo<TDestination>(config).ToArray();
        }

        public static TDestination[] ProjectToArray<TDestination>(this IQueryable queryable)
        {
            return queryable.ProjectTo<TDestination>().ToArray();
        }

        public static TDestination ProjectToSingleOrDefault<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return queryable.ProjectTo<TDestination>(config).SingleOrDefault();
        }

        public static TDestination ProjectToSingleOrDefault<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate, IConfigurationProvider config)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>(config).SingleOrDefault();
        }

        public static TDestination ProjectToSingleOrDefault<TDestination>(this IQueryable queryable)
        {
            return queryable.ProjectTo<TDestination>().SingleOrDefault();
        }

        public static TDestination ProjectToSingleOrDefault<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>().SingleOrDefault();
        }

        public static TDestination ProjectToSingle<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return queryable.ProjectTo<TDestination>(config).Single();
        }

        public static TDestination ProjectToSingle<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate, IConfigurationProvider config)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>(config).Single();
        }

        public static TDestination ProjectToSingle<TDestination>(this IQueryable queryable)
        {
            return queryable.ProjectTo<TDestination>().Single();
        }

        public static TDestination ProjectToSingle<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>().Single();
        }

        public static TDestination ProjectToFirstOrDefault<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return queryable.ProjectTo<TDestination>(config).FirstOrDefault();
        }

        public static TDestination ProjectToFirstOrDefault<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate, IConfigurationProvider config)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>(config).FirstOrDefault();
        }

        public static TDestination ProjectToFirstOrDefault<TDestination>(this IQueryable queryable)
        {
            return queryable.ProjectTo<TDestination>().FirstOrDefault();
        }

        public static TDestination ProjectToFirstOrDefault<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>().FirstOrDefault();
        }

        public static TDestination ProjectToFirst<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return queryable.ProjectTo<TDestination>(config).First();
        }

        public static TDestination ProjectToFirst<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate, IConfigurationProvider config)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>(config).First();
        }

        public static TDestination ProjectToFirst<TDestination>(this IQueryable queryable)
        {
            return queryable.ProjectTo<TDestination>().First();
        }

        public static TDestination ProjectToFirst<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>().First();
        }

        public static IQueryable<TDestination> ProjectToQueryable<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return queryable.ProjectTo<TDestination>(config);
        }

        public static IQueryable<TDestination> ProjectToQueryable<TDestination>(this IQueryable queryable)
        {
            return queryable.ProjectTo<TDestination>();
        }
    }
}